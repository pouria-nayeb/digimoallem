using DigiMoallem.BLL.DTOs.Accounts;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.EmailServices;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICourseService _courseService;
        private readonly IViewRenderService _viewRender;
        private readonly IConfiguration _config;

        public AccountController(IUserService userService, 
            ICourseService courseService, 
            IViewRenderService viewRender, 
            IConfiguration config)
        {
            _userService = userService;
            _courseService = courseService;
            _viewRender = viewRender;
            _config = config;
        }

        /// <summary>
        /// User register page.
        /// </summary>
        /// <returns>HTML Page</returns>
        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            SeedGroupsData();

            return View();
        }

        /// <summary>
        /// Implement logic to regsiter a user.
        /// </summary>
        /// <param name="register"> AccountViewModel </param>
        [Route("Register")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register, List<int> groupIds)
        {
            if (ModelState.IsValid)
            {
                #region recaptcha (authorize human-only)

                //if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
                //   _config["GoogleReCaptcha:secret"]))
                //{
                //    ModelState.AddModelError(string.Empty, "احراز هویت شما با موفقیت انجام نشد.");
                //    return View(register);
                //}

                #endregion

                // user inputs is valid
                if (await _userService.IsUserNameExistAsync(register.UserName.TextTransform()))
                {
                    // username is not unique
                    ModelState.AddModelError("UserName", "نام کاربری شما تکراری می باشد.");
                    SeedGroupsData();
                    return View(register);
                }

                if (await _userService.IsEmailExistAsync(register.Email.TextTransform()))
                {
                    // email is not unique
                    ModelState.AddModelError("Email", "ایمیل شما تکراری می باشد.");
                    SeedGroupsData();
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
                    _userService.AddGroupsToUser(user.UserId, groupIds);

                    #region ActivationEmail
                    // Send activation email
                    SendActivationEmail("_ActivationEmail", "فعالسازی حساب کاربری", user);
                    #endregion

                    // db success
                    return View("RegisterSuccess", user);
                }
                else
                {
                    // db failure
                    ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                    SeedGroupsData();
                    return View(register);
                }
            }

            // user inputs is not valid
            ViewData["NotValid"] = "کاربر گرامی، لطفاً اطلاعات معتبر وارد نمایید.";
            SeedGroupsData();
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
        public async Task<IActionResult> Login(LoginOptionsViewModel login, string ReturnUrl = null)
        {
            if (ModelState.IsValid)
            {
                #region recaptcha (authorize human-only)

                //if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
                //   _config["GoogleReCaptcha:secret"]))
                //{
                //    ModelState.AddModelError(string.Empty, "احراز هویت شما با موفقیت انجام نشد.");
                //    return View(login);
                //}

                #endregion

                // user inputs is valid
                var user = await _userService.LoginUserAsync(login.LoginVM);

                if (user != null)
                {
                    // user exist
                    if (user.IsActive)
                    {
                        user.UpdateDate = DateTime.Now;
                        _userService.UpdateUser(user);

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
                            IsPersistent = login.LoginVM.RememberMe
                        };

                        // Command will login the user
                        await HttpContext.SignInAsync(principal, properties);

                        #region SendEmailWhenUserLoggedIn
                        SendActivationEmail("_UserLoggedIn", "ورود کاربر", user);
                        #endregion

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
                        SendActivationEmail("_ActivationEmail", "فعالسازی حساب کاربری", user);

                        return View(login);
                    }
                }

                var existUser = await _userService.GetUserByEmailAsync(login.LoginVM.Email);

                if (existUser != null)
                {
                    if (existUser.Email == login.LoginVM.Email)
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

        [HttpPost]
        public async Task<IActionResult> LoginWithPhoneNumber(LoginOptionsViewModel login)
        {
            if (ModelState.IsValid)
            {
                #region recaptcha (authorize human-only)

                //if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
                //   _config["GoogleReCaptcha:secret"]))
                //{
                //    ModelState.AddModelError(string.Empty, "احراز هویت شما با موفقیت انجام نشد.");
                //    return View(login);
                //}

                #endregion

                // success
                var phoneNumber = login.LoginWithPhoneVM.PhoneNumber;

                if (_userService.GetAllUsers().Any(u => u.PhoneNumber == phoneNumber))
                {
                    // if found user with phonenumber
                    var user = _userService.GetUserByPhoneNumber(phoneNumber);

                    if (user != null)
                    {
                        // user exist
                        if (user.IsActive)
                        {
                            user.UpdateDate = DateTime.Now;
                            user.Token = new Random().Next(1000, 10000).ToString();
                            _userService.UpdateUser(user);

                            // send sms 
                            #region SendSms

                            string status = await SendMessage(
                                _config["SmsConfig:From"], 
                                phoneNumber, 
                                $"کد یکبار مصرف شما: {user.Token}", 
                                _config["SmsConfig:UserName"], 
                                _config["SmsConfig:Password"], 
                                _config["SmsConfig:Domain"]);

                            #endregion

                            if (string.IsNullOrEmpty(status))
                            {
                                // sms sending success
                                TempData["PhoneNumber"] = phoneNumber;
                                TempData["Message"] = "کد ورود برای شما ارسال شد.";
                                return RedirectToAction("LoginUserWithRandomToken", "Account");
                            }
                            else
                            {
                                // sms sending failed
                                ModelState.AddModelError("PhoneNumber", status);

                                return View("Login", login);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("PhoneNumber", "حساب کاربری خود را با پیام ارسالی فعال کنید.");

                            #region ActivationEmail
                            // Send activation email
                            SendActivationEmail("_ActivationEmail", "فعالسازی حساب کاربری", user);
                            #endregion

                            return View("Login", login);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("PhoneNumber", "کاربری با شماره مورد نظر یافت نشد.");
                        return View("Login", login);
                    }
                }
                else 
                {
                    ModelState.AddModelError("PhoneNumber", "شماره تلفن وارد شده در سایت ثبت نشده است.");
                    return View("Login", login);
                }
            }

            // failure
            ModelState.AddModelError("PhoneNumber", "ورودی نامعتبر.");
            return View("Login", login);
        }

        [HttpGet]
        public IActionResult LoginUserWithRandomToken() 
        {
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginUserWithRandomToken(LoginRandomTokenViewModel login, 
            string ReturnUrl = null) 
        {
            if (ModelState.IsValid)
            {
                string token = login.Token.Trim();
                if (_userService.GetAllUsers().Any(u => u.Token == token))
                {
                    string phoneNumber = TempData["PhoneNumber"] as string;
                    var user = _userService.GetUserByToken(phoneNumber, token);

                    user.UpdateDate = DateTime.Now;
                    user.Token = new Random().Next(1000, 10000).ToString();
                    _userService.UpdateUser(user);

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

                    #endregion

                    // login the user
                    await HttpContext.SignInAsync(principal, properties);

                    return RedirectToAction("Index", "Home");
                }
                else 
                {
                    // token not exist
                    ModelState.AddModelError("Token", "کد وارد شده معتبر نمی باشد.");
                    return View();
                }
            }

            // invalid user inputs
            ModelState.AddModelError("Token", "کد وارد شده صحیح نمی باشد.");
            return View();
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
            ViewData["Failure"] = "ورودی شما نامعتبر می باشد.";
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
            SendEmailClient.Send(user.Email, title, body);
        }

        public void SendActiveEmail(string specificPage, string title, string userToken)
        {
            string body = _viewRender.RenderToString(specificPage, userToken);
            SendEmailClient.Send("pouria-nayeb@outlook.com", title, body);
        }

        private void SeedGroupsData() {
            var groups = _courseService.GetGroupsToManageCourse();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");
        }

        private async Task<string> SendMessage(string from, string to, string text, string userName, string password, string domain)
        {
            // response code
            using (var client = new HttpClient())
            {
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync($"http://www.0098sms.com/sendsmslink.aspx?FROM={from}&TO={to}&TEXT={text}&USERNAME={userName}&PASSWORD={password}&DOMAIN={domain}"))
                    {
                        string apiResponse = (await response.Content.ReadAsStringAsync()).ToString().Substring(0, 1);

                        try
                        {
                            byte value = byte.Parse(apiResponse);
                            // convert response code to byte
                            //byte statusCode = byte.Parse(responseStatusCode);

                            // conversion success
                            switch (value)
                            {
                                case 0:
                                    return null;
                                case 1:
                                    return "شماره گیرنده اشتباه است.";
                                case 2:
                                    return "گیرنده تعریف نشده است.";
                                case 3:
                                    return "فرستنده تعریف نشده است.";
                                case 4:
                                    return "متن تنظیم نشده است.";
                                case 5:
                                    return "نام کاربری تنظیم نشده است.";
                                case 6:
                                    return "کلمه عبور تنظیم نشده است.";
                                case 7:
                                    return "نام دامین تنظیم نشده است.";
                                case 8:
                                    return "مجوز شما باطل شده است.";
                                case 9:
                                    return "اعتبار پیامکی شما کافی نیست.";
                                case 10:
                                    return "برای این شماره لینک تعریف نشده.";
                                case 11:
                                    return "عدم مجوز برای اتصال لینک.";
                                case 12:
                                    return "نام کاربری و کلمه عبور اشتباه است.";
                                case 13:
                                    return "کاراکتر غیر مجاز در متن وجود دارد.";
                                default:
                                    return "بروز خطا";
                            }
                        }
                        catch
                        {
                            // conversion failure
                            return "کد بازگشتی از سرور معتبر نمی باشد.";
                        }
                    }
                }
            }
        }

        #endregion
    }
}