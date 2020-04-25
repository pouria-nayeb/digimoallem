using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class IndexModel : PageModel
    {
        private IUserService _userService;
        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserViewModel UserViewModel { get; set; }

        public int UsersCount { get; set; }

        public async Task OnGetAsync(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            UserViewModel = await _userService.GetUsersAsync(pageId, filterEmail, filterUserName);
            UsersCount = await _userService.UsersCountAsync();
        }
    }
}