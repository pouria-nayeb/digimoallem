using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Users;
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
        private readonly IUserService _userService;

        public CreateModel(IAccountingService accountingService, ICourseService courseService, IUserService userService)
        {
            _accountingService = accountingService;
            _courseService = courseService;
            _userService = userService;
        }

        [BindProperty]
        public Payment Payment { get; set; }

        public User Teacher { get; set; }

        public async Task OnGet(int? id)
        {
            await SeedDataAsync(id);
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
                ViewData["Failure"] = "متاسفانه عملیات افزودن تراکنش توسط حسابدار با مشکل روبرو شد.";

                await SeedDataAsync(Teacher.UserId);

                return Page();
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";

            await SeedDataAsync(Teacher.UserId);

            return Page();
        }

        private async Task SeedDataAsync(int? id) {

            if (id.HasValue)
            {
                Teacher = _userService.GetUserById(id.Value);
            }

            List<SelectListItem> teachers = await _courseService
        .GetTeachersAsync();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

            List<SelectListItem> courses = await _courseService
                .GetCoursesItemListAsync();
            ViewData["Courses"] = new SelectList(courses, "Value", "Text");
        }
    }
}