﻿using DigiMoallem.BLL.DTOs.Works;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Works
{
    [PermissionChecker(36)]
    public class IndexModel : PageModel
    {
        private readonly IWorkService _workService;

        // step 1: create a constructor
        public IndexModel(IWorkService workService)
        {
            // step 2: inject message service
            _workService = workService;
        }

        // step 3: strong-binding
        public WorkPagingViewModel WorkPagingVM { get; private set; }

        public int WorksCount { get; private set; }

        public async Task<IActionResult> OnGetAsync(string email, int pageNumber = 1, int pageSize = 16)
        {
            if (!string.IsNullOrEmpty(email))
            {
                WorkPagingVM = await _workService.SearchWorksAsync(email, pageNumber, pageSize);

                return Page();
            }

            // step 4: feed ContactPagingVM and ContactsCount
            WorkPagingVM = await _workService.GetWorksAsync(pageNumber, pageSize);
            WorksCount = await _workService.WorksCountAsync();

            return Page();
        }
    }
}