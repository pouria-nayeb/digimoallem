using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    //[PermissionChecker(25)]
    public class EditEpisodeModel : PageModel
    {
        private ICourseService _courseService;

        public EditEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            CourseEpisode = await _courseService.GetEpisodeByIdAsync(id);

            if (CourseEpisode == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile fileEpisode)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.UpdateEpisodeAsync(CourseEpisode, fileEpisode))
                {
                    // success
                    TempData["Success"] = "بخش با موفقیت ویرایش شد.";
                    return LocalRedirect($"/Admin/Courses/Episodes/{CourseEpisode.CourseId}");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات ویرایش بخش توسط استاد با مشکل روبرو شد.";
                return LocalRedirect($"/Admin/Courses/EditEpisode/{CourseEpisode.CourseEpisodeId}");
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return LocalRedirect($"/Admin/Courses/EditEpisode/{CourseEpisode.CourseEpisodeId}");
        }
    }
}