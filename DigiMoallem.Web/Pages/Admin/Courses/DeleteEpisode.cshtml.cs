using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(1006)]
    public class DeleteEpisodeModel : PageModel
    {
        private ICourseService _courseService;

        public DeleteEpisodeModel(ICourseService courseService)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (await _courseService.RemoveEpisodeAsync(CourseEpisode.CourseEpisodeId))
            {
                // success
                TempData["Success"] = "بخش با موفقیت حذف شد.";
                return LocalRedirect($"/Admin/Courses/Episodes/{CourseEpisode.CourseId}");
            }

            // failure
            TempData["OperationFailed"] = "متاسفانه عملیات حذف بخش توسط استاد با مشکل روبرو شد.";
            return LocalRedirect($"/Admin/Courses/DeleteEpisode/{CourseEpisode.CourseEpisodeId}");
        }
    }
}