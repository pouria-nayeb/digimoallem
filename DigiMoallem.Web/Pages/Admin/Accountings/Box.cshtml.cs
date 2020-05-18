using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    [PermissionChecker(28)]
    public class BoxModel : PageModel
    {
        private readonly ICourseService _courseService;

        public BoxModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public OrderDetailPaymentPagingViewModel searchOrderVM { get; set; }

        public IActionResult OnGet(int id,
            string startDate,
            string endDate,
            int pageNumber = 1,
            int pageSize = 5000)
        {
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

            searchOrderVM = _courseService.SearchBox(gorgianStartDate, gorgianEndDate,
                pageNumber, pageSize);

            return Page();
        }
    }
}