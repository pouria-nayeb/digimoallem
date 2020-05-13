using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.DTOs.Admin.Users;
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
        private readonly IUserService _userService;

        public IndexModel(IAccountingService accountingService, IUserService userService)
        {
            _accountingService = accountingService;
            _userService = userService;
        }

        public UserViewModel UserVM { get; set; }

        public int TeachersCount { get; set; }

        public void OnGet(int pageId = 1)
        {
            UserVM = _userService.GetTeachers(pageId);

            TeachersCount = _userService.TeachersCount();
        }
    }
}