using DigiMoallem.BLL.DTOs.Accounts;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.EmailServices;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IViewRenderService _viewRender;

        public AccountController(IUserService userService, IViewRenderService viewRender)
        {
            _userService = userService;
            _viewRender = viewRender;
        }

        /// <summary>
        /// User register page
        /// </summary>
        /// <returns>HTML Page</returns>
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Implement logic to regsiter a user
        /// </summary>
        /// <param name="register"> AccountViewModel </param>
        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                if (await _userService.IsUserNameExistAsync(register.UserName.TextTransform()))
                {
                    // username is not unique
                    ModelState.AddModelError("UserName", "نام کاربری شما تکراری می باشد.");
                    return View(register);
                }

                if (await _userService.IsEmailExistAsync(register.Email.TextTransform()))
                {
                    // email is not unique
                    ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد.");
                    return View(register);
                }

                // create new user object
                var user = new User()
                {
                    UserName = register.UserName.TextTransform(),
                    Email = register.Email.TextTransform(),
                    Password = register.Password.EncodePassword(),
                    IsActive = false,
                    RegisterDate = DateTime.Now,
                    ActivationCode = CodeGenerator.GenerateUniqueCode(),
                    UserAvatar = "default.png"
                };

                if (await _userService.AddUserAsync(user) > 0)
                {
                    // Send activation email
                    SendActivationEmail("_ActivationEmail", "فعالسازی", user);

                    // db success
                    return View("RegisterSuccess", user);
                }
                else
                {
                    // db failure
                    ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                    return View(register);
                }
            }

            // user inputs is not valid
            ViewData["NotValid"] = "کاربر گرامی، لطفاً اطلاعات معتبر وارد نمایید.";
            return View(register);
        }

        /// <summary>
        /// User login page
        /// </summary>
        [Route("Login")]
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        /// <summary>
        /// Implement logic to login the user
        /// </summary>
        /// <param name="login"></param>
        /// <param name="ReturnUrl"></param>
        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                var user = await _userService.LoginUserAsync(login);

                if (user != null)
                {
                    // user exist
                    if (user.IsActive)
                    {
                        // user account is active
                        #region Claims (Data that we want access from the user)

                        var claims = new List<Claim>() {
                            new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                            new Claim(ClaimTypes.Name, user.UserName),
                            new Claim(ClaimTypes.Email, user.Email)
                        };

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        var principal = new ClaimsPrincipal(identity);

                        var properties = new AuthenticationProperties
                        {
                            IsPersistent = login.RememberMe
                        };

                        // Command will login the user
                        await HttpContext.SignInAsync(principal, properties);

                        #endregion

                        if (ReturnUrl != null)
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        // user account is not active
                        ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد، لطفاً به ایمیل خود مراجعه و حساب کاربری خود را فعال کنید.");

                        // Resend activation email
                        SendActivationEmail("_ActivationEmail", "فعالسازی", user);

                        return View(login);
                    }
                }

                var existUser = await _userService.GetUserByEmailAsync(login.Email);

                if (existUser != null)
                {
                    if (existUser.Email == login.Email)
                    {
                        ModelState.AddModelError("Password", "رمز عبور وارد شده صحیح نمی باشد.");
                        return View(login);
                    }
                }

                // user not registered yet
                ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد.");
                return View(login);
            }

            // user inputs is not valid
            ViewData["NotValid"] = "کاربر گرامی، لطفاً اطلاعات معتبر وارد نمایید.";
            return View(login);
        }

        /// <summary>
        /// Implement logic to logout the user
        /// </summary>
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        /// <summary>
        /// Forget password page
        /// </summary>
        [Route("ForgetPassword")]
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        /// <summary>
        /// Let user recover his/her password
        /// </summary>
        /// <param name="forgetPassword"></param>
        [Route("ForgetPassword")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPassword)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                User user = await _userService.GetUserByEmailAsync(forgetPassword.Email);

                if (user == null)
                {
                    // user not exist
                    ModelState.AddModelError("Email", "کاربری یافت نشد.");
                    return View(forgetPassword);
                }
                else
                {
                    // user exist
                    SendActivationEmail("_ForgetPassword", "بازیابی حساب کاربری", user);
                    ViewBag.IsSuccess = true;

                    return View();
                }
            }

            // user inputs is not valid
            return View(forgetPassword);
        }

        /// <summary>
        /// Reset password page
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {
                ActivationCode = id
            });
        }

        /// <summary>
        /// Let user to change his/her password for later usage
        /// </summary>
        /// <param name="resetPassword"></param>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPassword)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                var user = await _userService.GetUserByActivationCodeAsync(resetPassword.ActivationCode);

                if (user == null)
                {
                    // user not exist
                    return NotFound();
                }

                user.Password = resetPassword.Password.EncodePassword();
                if (await _userService.UpdateUserAsync(user))
                {
                    // success
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    // db failure
                    ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                    return View(resetPassword);
                }
            }

            // user inputs is not valid
            return View(resetPassword);
        }

        #region Helpers

        /// <summary>
        /// Activate user account
        /// </summary>
        /// <param name="activeCode"></param>
        public async Task<IActionResult> ActiveAccount(string id)
        {
            ViewBag.IsActive = await _userService.ActiveAccountAsync(id);
            return View();
        }

        /// <summary>
        /// Send activation code
        /// </summary>
        /// <param name="user"></param>
        public void SendActivationEmail(string specificPage, string title, User user)
        {
            string body = _viewRender.RenderToString(specificPage, user);
            SendEmail.Send(user.Email, title, body);
        }

        #endregion
    }
}