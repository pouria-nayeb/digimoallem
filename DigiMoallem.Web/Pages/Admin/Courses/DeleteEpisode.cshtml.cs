using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(26)]
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
            return await SeedCourseEpisodeData(id);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (await _courseService.RemoveEpisodeAsync(CourseEpisode.CourseEpisodeId))
            {
                // success
                TempData["Success"] = "بخش با موفقیت حذف شد.";
                return RedirectToPage("Episodes", new { id = CourseEpisode.CourseId });
            }

            // failure
            ViewData["Failure"] = "متاسفانه عملیات حذف بخش توسط استاد با مشکل روبرو شد.";
            return await SeedCourseEpisodeData(CourseEpisode.CourseEpisodeId);
        }

        #region Helpers
        private async Task<IActionResult> SeedCourseEpisodeData(int courseEpisodeId)
        {
            CourseEpisode = await _courseService.GetEpisodeByIdAsync(courseEpisodeId);

            if (CourseEpisode == null)
            {
                return NotFound();
            }

            return Page();
        }
        #endregion
    }
}