using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Groups
{
    [PermissionChecker(16)]
    public class EditModel : PageModel
    {
        private ICourseService _courseService;
        public EditModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Group Group { get; set; }

        public async Task OnGet(int id)
        {
            Group = await _courseService.GetGroupByIdAsync(id);
        }

        public async Task<IActionResult> OnPost(Group group, IFormFile imageName)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.UpdateGroupAsync(group, imageName))
                {
                    // success
                    TempData["Success"] = "گروه با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }
                else
                {
                    // failure
                    ViewData["OperationFailed"] = "متاسفانه عملیات ویرایش گروه توسط ادمین با شکست روبرو شد";
                    return Page();
                }
            }

            // user inputs is not valid
            ViewData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}