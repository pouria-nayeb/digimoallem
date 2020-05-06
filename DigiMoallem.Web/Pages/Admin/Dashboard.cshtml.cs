using DigiMoallem.BLL.Helpers.Security;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin
{
    [PermissionChecker(44)]
    public class DashboardModel : PageModel
    {
        public void OnGet() {}
    }
}
