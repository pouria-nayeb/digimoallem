using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DigiMoallem.BLL.Helpers.Security
{
    public class PermissionCheckerAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private int _permissionId;
        private IPermissionService _permissionService;
        public PermissionCheckerAttribute(int permissionId)
        {
            _permissionId = permissionId;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _permissionService = (IPermissionService)context.HttpContext
                .RequestServices
                .GetService(typeof(IPermissionService));

            var userIdentity = context.HttpContext.User.Identity;

            if (userIdentity.IsAuthenticated)
            {
                if (!_permissionService.CheckPermission(_permissionId, userIdentity.Name))
                {
                    // user do not have permission
                    context.Result = new RedirectResult("/Login?ReturnUrl=" + context.HttpContext.Request.Path);
                }
            }
            else
            {
                // user with no role (401 status code)
                context.Result = new RedirectResult("/Login");
            }
        }
    }
}
