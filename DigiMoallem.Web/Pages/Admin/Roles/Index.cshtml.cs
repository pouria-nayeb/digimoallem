using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.BLL.Services;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Roles
{
    [PermissionChecker(9)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        private readonly IUserService _userService;

        public IndexModel(IPermissionService permissionService, IUserService userService)
        {
            _permissionService = permissionService;
            _userService = userService;
        }

        public List<Role> Roles { get; set; }

        public int RolesCount { get; set; }

        public async Task OnGetAsync()
        {
            Roles = await _permissionService.GetRolesAsync();
            RolesCount = await _userService.RolesCountAsync();
        }
    }
}