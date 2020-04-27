﻿using DigiMoallem.BLL.DTOs.Display;
using DigiMoallem.BLL.DTOs.Works;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICourseService _courseService;
        private readonly IMessageService _messageService;
        private readonly IWorkService _workService;

        public HomeController(IUserService userService,
            ICourseService courseService,
            IMessageService messageService,
            IWorkService workService)
        {
            _userService = userService;
            _courseService = courseService;
            _messageService = messageService;
            _workService = workService;
        }

        /// <summary>
        /// AITranslate HomePage
        /// </summary>
        /// <returns>HTML Page</returns>
        public async Task<IActionResult> Index()
        {
            var indexVM = new IndexViewModel
            {
                Groups = await _courseService.GetGroupsAsync(),
                LatestCourses = await _courseService.GetLatestCourseAsync()
            };

            return View(indexVM);
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("Contact")]
        public async Task<IActionResult> Contact(Contact message)
        {
            message.SubmitDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                if ((await _messageService.AddContactAsync(message)) != null)
                {
                    TempData["Success"] = "پیام شما با موفقیت به دیجی معلم ارسال شد.";

                    return RedirectToAction("Contact", "Home");
                }
                else
                {
                    ViewData["DbFailure"] = "بروز خطا در سامانه لطفاً مراتب را به ایمیل info@digimoallem.ir گزارش دهید.";

                    return View();
                }
            }

            ViewData["InvalidInputs"] = "لطفاً اطلاعات خود را صحیح وارد نمایید.";

            return View();
        }

        [HttpGet]
        [Route("WorkWithUs")]
        public IActionResult WorkWithUs()
        {
            return View();
        }

        [HttpPost]
        [Route("WorkWithUs")]
        public async Task<IActionResult> WorkWithUs(WorkInitialDataViewModel workVM)
        {

            workVM.SubmitDate = DateTime.Now;

            if (await _userService.IsEmailExistAsync(workVM.Email.TextTransform()))
            {
                // email is not unique
                ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد.");
                return View(workVM);
            }

            if (ModelState.IsValid)
            {
                var work = await _workService.AddWorkAsync(workVM);
                if (work != null)
                {
                    var user = new User
                    {
                        UserName = workVM.Email,
                        FirstName = workVM.FirstName,
                        LastName = workVM.LastName,
                        Email = workVM.Email,
                        PhoneNumber = workVM.Mobile,
                        ActivationCode = CodeGenerator.GenerateUniqueCode(),
                        IsActive = true,
                        IsDelete = false,
                        Password = workVM.Mobile.EncodePassword(),
                        RegisterDate = workVM.SubmitDate
                    };

                    var userId = await _userService.AddUserAsync(user);

                    TempData["UserId"] = userId;

                    return RedirectToAction("WorkWithUsComplete", "Home", new { id = work.WorkId, userid = userId });
                }
                else
                {
                    ViewData["DbFailure"] = "بروز خطا در سامانه لطفاً مراتب را به ایمیل info@digimoallem.ir گزارش دهید.";

                    return View();
                }
            }

            ViewData["InvalidInputs"] = "لطفاً اطلاعات خود را صحیح وارد نمایید.";

            return View();
        }

        [HttpGet]
        [Route("WorkWithUsComplete")]
        public IActionResult WorkWithUsComplete(int id, int userid)
        {
            var work = _workService.GetWorkCompById(id);

            if (TempData["UserId"] == null)
            {
                return BadRequest();
            }

            int userId = (int)TempData["UserId"];

            if (userId == userid)
            {
                ViewBag.UserId = userid;
            }
            else {
                return BadRequest();
            }

            return View(work);
        }

        [HttpPost]
        [Route("WorkWithUsComplete")]
        public async Task<IActionResult> WorkWithUsComplete(WorkComplementDataViewModel workCVM, int userid)
        {
            if (ModelState.IsValid)
            {
                if ((await _workService.UpdateWorkAsync(workCVM)) != null)
                {
                    TempData["SuccessWork"] = "درخواست همکاری شما با موفقیت ثبت شد، تیم دیجی معلم در صورت تمایل با شما تماس خواهد گرفت.";

                    var user = await _userService.GetUserByIdAsync(userid);

                    user.Skills = workCVM.Skills;
                    user.Experiences = workCVM.Experiences;

                    return RedirectToAction("WorkWithUs", "Home");
                }
                else
                {
                    ViewData["DbFailure"] = "بروز خطا در سامانه لطفاً مراتب را به ایمیل info@digimoallem.ir گزارش دهید.";

                    return View();
                }
            }

            ViewData["InvalidInputs"] = "لطفاً اطلاعات خود را صحیح وارد نمایید.";

            return View();
        }

        /// <summary>
        /// User redirect to this page after successful transaction
        /// </summary>
        /// <param name="id"></param>
        [Route("OnlinePayment/{id?}")]
        public async Task<IActionResult> OnlinePayment(int? id)
        {
            if (id == null)
            {
                // 400 error
                return BadRequest();
            }

            var transaction = await _userService.GetTransactionByTransactionIdAsync(id);

            if (transaction == null)
            {
                // 404 error
                return NotFound();
            }

            if (HttpContext.Request.Query["Status"] != string.Empty &&
                HttpContext.Request.Query["Status"].ToString().TextTransform() == "ok" &&
                HttpContext.Request.Query["Authority"] != string.Empty)
            {

                string authority = HttpContext.Request.Query["Authority"];

                var payment = new Zarinpal.Payment("80b5d33a-2802-11ea-b693-000c295eb8fc", transaction.Amount);

                var response = await payment.Verification(authority);

                if (response.Status == 100)
                {
                    // online payment succeeded
                    ViewData["ReferenceId"] = response.RefId;
                    ViewData["IsSucceeded"] = true;

                    transaction.IsPay = true;
                    await _userService.UpdateTransactionAsync(transaction);
                }
            }

            return View();
        }

        /// <summary>
        /// Get all subgroups of courses for ajax call
        /// </summary>
        /// <param name="id"></param>

        public IActionResult GetSubGroups(int id)
        {
            var subGroups = new List<SelectListItem>() {
                new SelectListItem() { Text = "یکی از زیرگروه ها را انتخاب نمایید", Value = ""}
            };

            subGroups.AddRange(_courseService.GetSubGroupsToManageCourse(id));
            return Json(new SelectList(subGroups, "Value", "Text"));
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/MyImages", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);
            }

            var url = $"{"/MyImages/"}{fileName}";

            return Json(new { uploaded = true, url });
        }
    }
}