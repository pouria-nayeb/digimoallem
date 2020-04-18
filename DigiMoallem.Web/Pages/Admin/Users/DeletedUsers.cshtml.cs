using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(5)]
    public class DeletedUsersModel : PageModel
    {
        private IUserService _userService;
        public DeletedUsersModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserViewModel UserViewModel { get; set; }

        public async Task OnGetAsync(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            UserViewModel = await _userService.GetDeletedUsersAsync(pageId, filterEmail, filterUserName);
        }
    }
}