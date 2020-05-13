using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(25)]
    public class EditEpisodeByAdminModel : PageModel
    {
        private ICourseService _courseService;

        public EditEpisodeByAdminModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            return await SeedCourseEpisodeData(id);
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
                    return RedirectToPage("AllEpisodes");
                }

                // failure
                ViewData["Failure"] = "متاسفانه عملیات ویرایش بخش توسط استاد با مشکل روبرو شد.";
                return await SeedCourseEpisodeData(CourseEpisode.CourseEpisodeId);
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";
            return await SeedCourseEpisodeData(CourseEpisode.CourseEpisodeId);
        }

        #region Helpers
        private async Task<IActionResult> SeedCourseEpisodeData(int episodeCourseId)
        {
            CourseEpisode = await _courseService.GetEpisodeByIdAsync(episodeCourseId);

            if (CourseEpisode == null)
            {
                return NotFound();
            }

            return Page();
        }
        #endregion
    }
}