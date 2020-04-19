using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Roles
{
    [PermissionChecker(12)]
    public class DeleteModel : PageModel
    {
        private IPermissionService _permissionService;
        public DeleteModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [BindProperty]
        public Role Role { get; set; }

        public async Task OnGetAsync(int id)
        {
            Role = await _permissionService.GetRoleByIdAsync(id);
            ViewData["Permissions"] = _permissionService.GetPermissionNamesOfRole(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (await _permissionService.DeleteRoleAsync(Role))
            {
                // success
                TempData["Success"] = "نقش با موفقیت حذف شد.";
                return RedirectToPage("Index");
            }
            else
            {
                // failure
                return RedirectToPage("Delete", new {id = Role.RoleId});
            }
        }
    }
}