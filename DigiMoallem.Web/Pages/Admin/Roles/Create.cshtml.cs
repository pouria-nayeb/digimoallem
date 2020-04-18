using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Roles
{
    [PermissionChecker(1003)]
    public class CreateModel : PageModel
    {
        private IPermissionService _permissionService;
        public CreateModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }

        public void OnGet()
        {
            ViewData["Permissions"] = _permissionService.GetAllPermissions();
        }

        public async Task<IActionResult> OnPostAsync(List<int> selectedPermission)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                Role.IsDelete = false;
                if (await _permissionService.AddRoleAsync(Role) != -1)
                {
                    // success
                    if (await _permissionService.AddPermissionsToRoleAsync(Role.RoleId, selectedPermission))
                    {
                        // success (permission)
                        TempData["Success"] = "نقش با موفقیت افزوده شد.";
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        // failure
                        TempData["OperationFailed"] = "متاسفانه عملیات افزودن دسترسی به نقش توسط ادمین با مشکل روبرو شد.";
                        return Page();
                    }
                }
                else
                {
                    // failure
                    TempData["OperationFailed"] = "متاسفانه عملیات افزودن نقش توسط ادمین با مشکل روبرو شد.";
                    return Page();
                }
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}