using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
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
            return View(await _userService.GetDetailsToEditUserProfileAsync(User.Identity.Name));
        }

        /// <summary>
        /// Implement logic to edit user profile
        /// </summary>
        /// <param name="model"></param>
        [Route("UserPanel/Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditProfileViewModel profile)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                var user = await _userService.GetUserByUserNameAsync(User.Identity.Name);

                if (await _userService.IsEmailExistAsync(profile.Email.TextTransform()) && user.Email != profile.Email.TextTransform())
                {
                    // email is not unique
                    ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد.");
                    return View(profile);
                }

                if (await _userService.UpdateProfileAsync(User.Identity.Name, profile))
                {
                    // success
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
    }
}