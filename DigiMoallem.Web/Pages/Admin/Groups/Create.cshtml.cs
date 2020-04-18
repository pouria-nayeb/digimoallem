using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Groups
{
    public class CreateModel : PageModel
    {
        private ICourseService _courseService;
        public CreateModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Group Group { get; set; }

        public void OnGet(int? id)
        {
            Group = new Group()
            {
                ParentId = id
            };
        }

        public async Task<IActionResult> OnPostAsync(Group group, IFormFile imageName)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.AddGroupAsync(group, imageName))
                {
                    // success
                    TempData["Success"] = "گروه با موفقیت افزوده شد.";
                    return RedirectToPage("Index");
                }
                else
                {
                    // failure
                    ViewData["OperationFailed"] = "متاسفانه عملیات افزودن گروه توسط ادمین با شکست روبرو شد";
                    return Page();
                }
            }

            // user inputs are not valid
            ViewData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}