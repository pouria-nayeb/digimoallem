using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Roles
{
    [PermissionChecker(11)]
    public class EditModel : PageModel
    {
        private IPermissionService _permissionService;
        public EditModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }

        public async Task OnGetAsync(int id)
        {
            ViewData["Permissions"] = _permissionService.GetAllPermissions();
            ViewData["SelectedPermissions"] = _permissionService.GetPermissionsOfRole(id);
            Role = await _permissionService.GetRoleByIdAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(List<int> selectedPermission)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                Role.IsDelete = false;
                if (await _permissionService.UpdateRoleAsync(Role))
                {
                    // success
                    if (await _permissionService.UpdatePermissionsOfRoleAsync(Role.RoleId, selectedPermission))
                    {
                        // success (edit permissions)
                        TempData["Success"] = "نقش با موفقیت ویرایش شد.";
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        // failure (edit permissions)
                        TempData["OperationFailed"] = "متاسفانه عملیات ویرایش تخصیص دسترسی ها توسط ادمین با مشکل روبرو شد.";
                        return Page();
                    }
                }
                else
                {
                    // failure
                    TempData["OperationFailed"] = "متاسفانه عملیات ویرایش نقش توسط ادمین با مشکل روبرو شد.";
                    return Page();
                }
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}