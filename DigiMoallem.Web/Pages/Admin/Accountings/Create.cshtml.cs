using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Accounting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class CreateModel : PageModel
    {
        private IAccountingService _accountingService;
        private ICourseService _courseService;

        public CreateModel(IAccountingService accountingService, ICourseService courseService)
        {
            _accountingService = accountingService;
            _courseService = courseService;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public async Task OnGet()
        {
            List<SelectListItem> teachers = await _courseService
                .GetTeachersAsync();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

            List<SelectListItem> courses = await _courseService
                .GetCoursesItemListAsync();
            ViewData["Courses"] = new SelectList(courses, "Value", "Text");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Payment.PaymentDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _accountingService.AddPaymentAsync(Payment))
                {
                    // success
                    TempData["Success"] = "تراکنش با موفقیت افزوده شد.";
                    return RedirectToPage("Index");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات افزودن تراکنش توسط حسابدار با مشکل روبرو شد.";
                return Page();
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}