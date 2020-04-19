using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(4)]
    public class CreateModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        public CreateModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        [BindProperty]
        public CreateUserViewModel CreateUserViewModel { get; set; }

        public async Task OnGetAsync()
        {
            ViewData["Roles"] = await _permissionService.GetRolesAsync();
        }

        public async Task<IActionResult> OnPostAsync(List<int> SelectedRoles)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid
                string userName = CreateUserViewModel.UserName.TextTransform();

                if (await _userService.IsUserNameExistAsync(userName))
                {
                    TempData["UserNameExist"] = "این نام کاربری تکراری است.";
                    return LocalRedirect("/Admin/Users/Create");
                }

                if (await _userService.IsEmailExistAsync(CreateUserViewModel.Email.TextTransform()))
                {
                    TempData["EmailExist"] = "این ایمیل تکراری است.";
                    return LocalRedirect("/Admin/Users/Create");
                }

                // add the user
                int userId = await _userService.AddUserByAdminAsync(CreateUserViewModel);

                if (await _permissionService.AssignRolesToUserAsync(SelectedRoles, userId))
                {
                    // success
                    TempData["Success"] = "کاربر با موفقیت افزوده شد.";
                    return LocalRedirect("/Admin/Users");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات افزودن کاربر توسط ادمین با مشکل روبرو شد.";
                return Page();
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            ViewData["Roles"] = await _permissionService.GetRolesAsync();
            return Page();
        }
    }
}