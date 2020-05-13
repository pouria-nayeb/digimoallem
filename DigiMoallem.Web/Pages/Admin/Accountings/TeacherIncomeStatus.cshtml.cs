using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class TeacherIncomeStatusModel : PageModel
    {
        private readonly ICourseService _courseService;

        public TeacherIncomeStatusModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public SearchOrderViewModel searchOrderVM { get; set; }

        [ViewData]
        public int Id { get; set; }

        public IActionResult OnGet(int id, 
            string startDate, 
            string endDate, 
            int pageNumber = 1, 
            int pageSize = 2000)
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

            Id = id;

            searchOrderVM = _courseService.AdvanceSearchCourse(gorgianStartDate, gorgianEndDate, id,
                pageNumber, pageSize);

            return Page();
        }
    }
}