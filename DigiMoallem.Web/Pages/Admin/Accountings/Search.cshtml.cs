using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class SearchModel : PageModel
    {
        private readonly ICourseService _courseService;

        public SearchModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public SearchOrderViewModel searchOrderVM { get; set; }

        public async Task<IActionResult> OnGetAsync(string startDate, string endDate, int teacherId, int pageNumber = 1, int pageSize = 16)
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

            List<SelectListItem> teachers = await _courseService
            .GetTeachersAsync();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

            searchOrderVM = _courseService.AdvanceSearchCourse(gorgianStartDate, gorgianEndDate, teacherId, 
                pageNumber, pageSize);

            return Page();
        }
    }
}