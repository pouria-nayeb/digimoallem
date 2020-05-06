using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DigiMoallem.Web.Pages.Admin.Standards
{
    [PermissionChecker(45)]
    public class IndexModel : PageModel
    {
        private readonly IStandardService _standardService;

        public IndexModel(IStandardService standardService)
        {
            _standardService = standardService;
        }

        public List<Standard> Standards { get; private set; }

        public byte StandardsCount { get; private set; }

        public void OnGet()
        {
            Standards = _standardService.GetStandards();

            StandardsCount = _standardService.StandardsCount();
        }
    }
}