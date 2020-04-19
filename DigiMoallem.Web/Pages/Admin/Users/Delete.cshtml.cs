using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(6)]
    public class DeleteModel : PageModel
    {
        private IUserService _userService;
        public DeleteModel(IUserService userService)
        {
            _userService = userService;
        }

        [ViewData]
        public int Id { get; set; }

        public UserPanelViewModel UserPanelViewModel { get; set; }

        public async Task OnGetAsync(int id)
        {
            Id = id;
            UserPanelViewModel = await _userService.GetUserDetailsAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (await _userService.DeleteUserAsync(id))
            {
                // success
                TempData["Success"] = "کاربر با موفقیت حذف شد.";
                return LocalRedirect("/Admin/Users");
            }
            else {
                // failure
                return LocalRedirect($"/Admin/Users/Delete/{id}");
            }
        }
    }
}