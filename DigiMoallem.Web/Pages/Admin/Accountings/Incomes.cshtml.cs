using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class IncomesModel : PageModel
    {
        private readonly ICourseService _courseService;

        public IncomesModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IncomePagingViewModel IncomesVM { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 32)
        {
            IncomesVM = await _courseService.GetIncomesForAdminAsync(pageNumber, pageSize);
        }
    }
}