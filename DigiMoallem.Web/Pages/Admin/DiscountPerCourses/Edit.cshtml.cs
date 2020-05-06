using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.DiscountPerCourses
{
    [PermissionChecker(21)]
    public class EditModel : PageModel
    {
        private readonly IDiscountPerCourseService _discountPerCourseService;
        private readonly ICourseService _courseService;

        public EditModel(IDiscountPerCourseService discountPerCourseService,
            ICourseService courseService)
        {
            _discountPerCourseService = discountPerCourseService;
            _courseService = courseService;
        }

        [BindProperty]
        public DiscountPerCourse Discount { get; set; }

        public SelectList CoursesSelectList { get; set; }

        public IActionResult OnGet(int id)
        {
            Discount = _discountPerCourseService.GetDiscountById(id);
            SeedCourses();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string startDate, string endDate)
        {
            if (!string.IsNullOrEmpty(startDate))
            {
                // feed start date
                string[] startDateArray = startDate.Split("/");
                Discount.StartDate = new DateTime(
                    int.Parse(startDateArray[0]),
                    int.Parse(startDateArray[1]),
                    int.Parse(startDateArray[2]),
                    new PersianCalendar()
                );
            }

            if (!string.IsNullOrEmpty(endDate))
            {
                // feed end date
                string[] endDateArray = endDate.Split("/");
                Discount.EndDate = new DateTime(
                    int.Parse(endDateArray[0]),
                    int.Parse(endDateArray[1]),
                    int.Parse(endDateArray[2]),
                    new PersianCalendar()
                );
            }

            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (_discountPerCourseService.UpdateDiscount(Discount))
                {
                    // success
                    TempData["Success"] = "کد تخفیف با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }

                // failure
                ViewData["Failure"] = "متاسفانه عملیات ویرایش کد تخفیف توسط ادمین با مشکل روبرو شد.";
                SeedCourses();
                return Page();
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";
            SeedCourses();
            return Page();
        }

        private void SeedCourses()
        {
            var courses = _courseService.GetCoursesItemList();
            CoursesSelectList = new SelectList(courses, "Value", "Text");
        }
    }
}