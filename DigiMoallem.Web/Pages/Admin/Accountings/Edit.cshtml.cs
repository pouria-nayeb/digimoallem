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
    public class EditModel : PageModel
    {
        private IAccountingService _accountingService;
        private ICourseService _courseService;

        public EditModel(IAccountingService accountingService, ICourseService courseService)
        {
            _accountingService = accountingService;
            _courseService = courseService;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public async Task OnGetAsync(int id)
        {
            Payment = await _accountingService.GetPaymentByIdAsync(id);

            List<SelectListItem> teachers = new List<SelectListItem>() {
                new SelectListItem() { Text = "انتخاب کنید", Value = "" }
            };
            teachers.AddRange(await _courseService.GetTeachersAsync());

            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text", Payment.TeacherId);


            List<SelectListItem> courses = new List<SelectListItem>() {
                new SelectListItem() { Text = "انتخاب کنید", Value = "" }
            };
            courses.AddRange(await _courseService.GetCoursesItemListAsync());
            ViewData["Courses"] = new SelectList(courses, "Value", "Text", Payment.CourseId);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Payment.PaymentDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _accountingService.UpdatePaymentAsync(Payment))
                {
                    // success
                    TempData["Success"] = "تراکنش با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات ویرایش تراکنش توسط حسابدار با مشکل روبرو شد.";
                return Page();
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}