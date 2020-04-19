using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Groups
{
    [PermissionChecker(17)]
    public class DeleteModel : PageModel
    {
        private ICourseService _courseService;
        public DeleteModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Group Group { get; set; }

        public async Task OnGetAsync(int id)
        {
            Group = await _courseService.GetGroupByIdAsync(id);
        }

        public async Task<IActionResult> OnPostAsync(Group group)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.DeleteGroupAsync(Group))
                {
                    // success
                    TempData["Success"] = "دسته بندی محصول با موفقیت حذف شد.";
                    return RedirectToPage("Index");
                }
                else
                {
                    // failure
                    ViewData["OperationFailed"] = "متاسفانه عملیات حذف دسته بندی توسط ادمین با شکست روبرو شد";
                    return Page();
                }
            }

            // user inputs is not valid
            ViewData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}