using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.Helpers.EmailServices;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Users
{
    [PermissionChecker(5)]
    public class EditModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        private readonly IViewRenderService _viewRender;

        public EditModel(IUserService userService, IPermissionService permissionService, IViewRenderService viewRender)
        {
            _userService = userService;
            _permissionService = permissionService;
            _viewRender = viewRender;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }

        public async Task OnGetAsync(int id)
        {
            await SeedUserData(id);
        }

        public async Task<IActionResult> OnPostAsync(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                // failure (wrong user input)
                ViewData["Failure"] = "ورودی شما نامعتبر است.";
                await SeedUserData(EditUserViewModel.UserId);
                return Page();
            }

            if (await _userService.UpdateUserByAdminAsync(EditUserViewModel))
            {
                // success
                TempData["Success"] = "ویرایش با موفقیت انجام شد.";
                await _permissionService.EditRolesAssignedAsync(EditUserViewModel.UserId, SelectedRoles);

                var user = await _userService.GetUserByIdAsync(EditUserViewModel.UserId);

                // Send activation email
                if (user.PhoneNumber != null)
                {
                    SendActivationEmail("_TeacherActivationEmail", "فعالسازی", user);
                }

                return RedirectToPage("Index");
            }

            // failure (edit operation failed)
            ViewData["Failure"] = "متاسفانه عملیات ویرایش کاربر توسط ادمین با مشکل روبرو شد.";
            await SeedUserData(EditUserViewModel.UserId);
            return Page();
        }
        /// <summary>
        /// Send activation code
        /// </summary>
        /// <param name="user"></param>
        public void SendActivationEmail(string specificPage, string title, User user)
        {
            string body = _viewRender.RenderToString(specificPage, user);
            SendEmailClient.Send(user.Email, title, body);
        }

        private async Task SeedUserData(int id) {
            EditUserViewModel = await _userService.GetUserDetailsForEditAsync(id);
            ViewData["Roles"] = await _permissionService.GetRolesAsync();
        }
    }
}