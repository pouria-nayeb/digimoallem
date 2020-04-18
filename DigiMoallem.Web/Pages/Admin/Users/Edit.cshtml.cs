using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(4)]
    public class EditModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public EditModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }

        public async Task OnGetAsync(int id)
        {
            EditUserViewModel = await _userService.GetUserDetailsForEditAsync(id);
            ViewData["Roles"] = await _permissionService.GetRolesAsync();
        }

        public async Task<IActionResult> OnPostAsync(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                // failure (wrong user input)
                TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
                return LocalRedirect($"/Admin/Users/Edit/{EditUserViewModel.UserId}");
            }

            if (await _userService.UpdateUserByAdminAsync(EditUserViewModel))
            {
                // success
                TempData["Success"] = "ویرایش با موفقیت انجام شد.";
                await _permissionService.EditRolesAssignedAsync(EditUserViewModel.UserId, SelectedRoles);
                return LocalRedirect("/admin/users");
            }

            // failure (edit operation failed)
            TempData["OperationFailed"] = "متاسفانه عملیات ویرایش کاربر توسط ادمین با مشکل روبرو شد.";
            return LocalRedirect($"/Admin/Users/Edit/{EditUserViewModel.UserId}");
        }
    }
}