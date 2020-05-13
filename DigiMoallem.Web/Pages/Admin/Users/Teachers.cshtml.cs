using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    public class TeachersModel : PageModel
    {
        private IUserService _userService;
        public TeachersModel(IUserService userService)
        {
            _userService = userService;
        }

        public UserViewModel UserViewModel { get; set; }

        public int UsersCount { get; set; }

        public async Task OnGetAsync(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            UserViewModel = _userService.GetTeachers(pageId, filterEmail, filterUserName);
            UsersCount = await _userService.TeachersCountAsync();
        }
    }
}