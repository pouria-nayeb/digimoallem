using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Purifications
{
    [PermissionChecker(49)]
    public class IndexModel : PageModel
    {
        private readonly IAccountingService _accountingService;

        public IndexModel(IAccountingService accountingService)
        {
            _accountingService = accountingService;
        }

        public PurificationPagingViewModel PurificationVM { get; private set; }

        public int PurificationsCount { get; private set; }

        public void OnGet(int pageNumber = 1, int pageSize = 32)
        {
            PurificationVM = _accountingService.GetPurifications(pageNumber, pageSize);

            PurificationsCount = _accountingService.PurificationsCount();
        }
    }
}