using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    [PermissionChecker(28)]
    public class IndexModel : PageModel
    {
        private IAccountingService _accountingService;

        public IndexModel(IAccountingService accountingService)
        {
            _accountingService = accountingService;
        }

        public AccountingViewModel PaymentVM { get; set; }

        public async Task OnGetAsync(int pageId = 1, int pageSize = 20)
        {
            PaymentVM = await _accountingService.GetPaymentsAsync(pageId, pageSize);
        }
    }
}