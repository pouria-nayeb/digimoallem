using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Roles
{
    [PermissionChecker(1002)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> Roles { get; set; }

        public async Task OnGetAsync()
        {
            Roles = await _permissionService.GetRolesAsync();
        }
    }
}