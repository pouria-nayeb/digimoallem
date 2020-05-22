using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.EmailServices;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IAccountingService _accountingService;
        private readonly IViewRenderService _viewRender;
        private readonly ICourseService _courseService;

        public HomeController(IUserService userService,
            IAccountingService accountingService,
            IViewRenderService viewRender,
            ICourseService courseService)
        {
            _userService = userService;
            _accountingService = accountingService;
            _viewRender = viewRender;
            _courseService = courseService;
        }

        /// <summary>
        /// Display user details
        /// </summary>
        public async Task<IActionResult> Index()
        {
            return View(await _userService.GetUserDetailsAsync(User.Identity.Name));
        }

        /// <summary>
        /// Edit user profile page
        /// </summary>
        [HttpGet]
        [Route("UserPanel/Edit")]
        public async Task<IActionResult> Edit()
        {
            SeedGroupsSelectListData();

            return View(await _userService.GetDetailsToEditUserProfileAsync(User.Identity.Name));
        }

        /// <summary>
        /// Implement logic to edit user profile
        /// </summary>
        /// <param name="model"></param>
        [Route("UserPanel/Edit")]
        [HttpPost]
        public async Task<IActionResult> Edit(EditProfileViewModel profile, List<int> groupIds)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                var user = await _userService.GetUserByUserNameAsync(User.Identity.Name);

                if (await _userService.IsEmailExistAsync(profile.Email.TextTransform()) && 
                    user.Email != profile.Email.TextTransform())
                {
                    // email is not unique
                    ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد.");

                    SeedGroupsSelectListData();

                    return View(profile);
                }

                if (!string.IsNullOrEmpty(profile.PhoneNumber) && user.PhoneNumber == null)
                {
                    if (await _userService.IsPhoneNumberExistAsync(profile.PhoneNumber))
                    {
                        // phoneNumber is not unique
                        ModelState.AddModelError("PhoneNumber", "تلفن تماس شما تکراری می باشد.");

                        SeedGroupsSelectListData();

                        return View(profile);
                    }
                }

                if (!string.IsNullOrEmpty(profile.PhoneNumber) && user.PhoneNumber != profile.PhoneNumber)
                {
                    if (await _userService.IsPhoneNumberExistAsync(profile.PhoneNumber))
                    {
                        // phoneNumber is not unique
                        ModelState.AddModelError("PhoneNumber", "تلفن تماس شما تکراری می باشد.");

                        SeedGroupsSelectListData();

                        return View(profile);
                    }
                }

                if (await _userService.UpdateProfileAsync(User.Identity.Name, profile))
                {
                    // success
                    profile.UpdateDate = DateTime.Now;

                    _userService.UpdateGroupsOfUser(user.UserId, groupIds);

                    // Send activation email
                    #region UpdateProfileData
                    SendActivationEmail("_UserUpdateProfile", "به روزرسانی پروفایل", profile);
                    #endregion

                    TempData["Success"] = "اطلاعات شما در سامانه با موفقیت ویرایش شد.";
                    return LocalRedirect("/UserPanel");
                }
                else
                {
                    // db failure
                    ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                    return View(profile);
                }
            }

            // user inputs is not valid
            SeedGroupsSelectListData();

            return View(profile);
        }

        [Route("UserPanel/ChangePassword")]
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Route("UserPanel/ChangePassword")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePassword)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _userService.CompareOldPasswordAsync(changePassword.OldPassword, User.Identity.Name))
                {
                    // current password is valid

                    if (await _userService.ChangeUserPasswordAsync(User.Identity.Name, changePassword.Password))
                    {
                        // success
                        TempData["Success"] = "رمز عبور شما در سامانه با موفقیت ویرایش شد.";
                        return LocalRedirect("/UserPanel");
                    }
                    else
                    {
                        // db failure
                        ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                        return View(changePassword);
                    }
                }
                else
                {
                    // failure
                    ModelState.AddModelError("OldPassword", "رمز عبور فعلی صحیح نمی باشد.");
                }
            }

            // user inputs is not valid
            return View(changePassword);
        }

        [HttpPost]
        public IActionResult AccountPurification(Purification purification) 
        {
            purification.SubmitDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (_accountingService.AddPurification(purification) != null)
                {
                    TempData["Success"] = "درخواست شما برای تصفیه با موفقیت ارسال شد.";
                    return RedirectToAction("Index", "Home", new { area = "UserPanel" });
                }
                else 
                {
                    TempData["Failure"] = "بروز خطا در پایگاه داده، لطفاً مراقب را به مدیریت سایت گزارش دهید.";
                    return RedirectToAction("Index", "Home", new { area = "UserPanel" });
                }
            }

            TempData["Failure"] = "ورودی نامعتبر";
            return RedirectToAction("Index", "Home", new { area = "UserPanel" });
        }

        [Route("Payments/{id}")]
        public async Task<IActionResult> TeacherPayments(int id, int pageNumber = 1, int pageSize = 32) 
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user.UserName.TextTransform() == User.Identity.Name.TextTransform())
            {
                var teacherPayments = await _accountingService
                .GetTeacherPaymentByUserNameAsync(id, pageNumber, pageSize);

                return View(teacherPayments);
            }

            return BadRequest();
        }

        [Route("TeacherCourses/{id}")]
        public IActionResult TeacherCourses(int id,int pageNumber = 1, int pageSize = 16)
        {
            CourseViewModel courses = _courseService.GetCoursesOfTeacher(id, pageNumber, pageSize);

            return View(courses);
        }

        [Route("TeacherShare/{id}")]
        public IActionResult TeacherShare(int id, string startDate, string endDate) 
        {
            int teacherId = _userService.GetUserIdByUserName(User.Identity.Name);

            ViewData["CourseId"] = id;

            DateTime gorgianStartDate;
            if (!string.IsNullOrEmpty(startDate))
            {
                // feed start date
                string[] startDateArray = startDate.Split("/");
                gorgianStartDate = new DateTime(
                    int.Parse(startDateArray[0]),
                    int.Parse(startDateArray[1]),
                    int.Parse(startDateArray[2]),
                    new PersianCalendar()
                );
            }
            else
            {
                gorgianStartDate = DateTime.Now.AddDays(-29);
            }

            DateTime gorgianEndDate;
            if (!string.IsNullOrEmpty(endDate))
            {
                // feed end date
                string[] endDateArray = endDate.Split("/");
                gorgianEndDate = new DateTime(
                    int.Parse(endDateArray[0]),
                    int.Parse(endDateArray[1]),
                    int.Parse(endDateArray[2]),
                    new PersianCalendar()
                );
            }
            else
            {
                gorgianEndDate = DateTime.Now.AddDays(2);
            }

            var searchOrderVM = _courseService.AdvanceSearchCourseAndTeacher(gorgianStartDate, gorgianEndDate, teacherId, id, 1, 2000);

            return View(searchOrderVM);
        }

        #region Helpers

        /// <summary>
        /// Send activation code
        /// </summary>
        /// <param name="user"></param>
        public void SendActivationEmail(string specificPage, string title, EditProfileViewModel profile)
        {
            string body = _viewRender.RenderToString(specificPage, profile);
            SendEmailClient.Send(profile.Email, title, body);
        }

        private void SeedGroupsSelectListData()
        {
            var groups = _courseService.GetGroupsToManageCourse();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
        }

        #endregion
    }
}