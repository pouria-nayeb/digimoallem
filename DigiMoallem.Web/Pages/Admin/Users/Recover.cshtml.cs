using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(7)]
    public class RecoverModel : PageModel
    {
        private IUserService _userService;
        public RecoverModel(IUserService userService)
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
            if (await _userService.RecoverDeletedUserAsync(id))
            {
                // success
                TempData["Success"] = "کاربر حذف شده با موفقیت بازیابی شد.";
                return LocalRedirect("/Admin/Users");
            }
            else
            {
                // failure
                TempData["RecoverUser"] = "بروز خطا در دیتابیس، امکان بازیابی این کاربر وجود ندارد.";
                return LocalRedirect("/Admin/Users/Delete");
            }
        }
    }
}