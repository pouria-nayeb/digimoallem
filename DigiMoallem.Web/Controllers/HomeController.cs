using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Interfaces;
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

        public HomeController(IUserService userService,
            ICourseService courseService)
        {
            _userService = userService;
            _courseService = courseService;
        }

        /// <summary>
        /// AITranslate HomePage
        /// </summary>
        /// <returns>HTML Page</returns>
        public async Task<IActionResult> Index()
        {
            ViewBag.PopularCourses = await _courseService.GetPopularCoursesAsync();
            return View(await _courseService.GetLatestCourseAsync());
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

        //[HttpPost]
        //[Route("Contact")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Contact(Ticket ticket)
        //{
        //    ticket.SubmissionDate = DateTime.Now;

        //    if (ModelState.IsValid)
        //    {
        //        if ((await _ticketService.AddTicketAsync(ticket)) != null)
        //        {
        //            TempData["Success"] = "پیام شما با موفقیت به دیجی معلم ارسال شد.";

        //            return RedirectToAction("Contact", "Home");
        //        }
        //        else
        //        {
        //            ViewData["DbFailure"] = "بروز خطا در سامانه لطفاً مراتب را به ایمیل info@digimoallem.ir گزارش دهید.";

        //            return View();
        //        }
        //    }

        //    ViewData["InvalidInputs"] = "لطفاً اطلاعات خود را صحیح وارد نمایید.";

        //    return View();
        //}

        [HttpGet]
        [Route("Contribute")]
        public IActionResult Contribute()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("Contribute")]
        //public async Task<IActionResult> Contribute(Job job)
        //{

        //    job.SubmissionDate = DateTime.Now;

        //    if (ModelState.IsValid)
        //    {
        //        if ((await _contributeService.AddJobAsync(job)) != null)
        //        {
        //            TempData["Success"] = "درخواست شما با موفقیت به دیجی معلم ارسال شد.";

        //            return RedirectToAction("Contribute", "Home");
        //        }
        //        else
        //        {
        //            ViewData["DbFailure"] = "بروز خطا در سامانه لطفاً مراتب را به ایمیل info@digimoallem.ir گزارش دهید.";

        //            return View();
        //        }
        //    }

        //    ViewData["InvalidInputs"] = "لطفاً اطلاعات خود را صحیح وارد نمایید.";

        //    return View();
        //}

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