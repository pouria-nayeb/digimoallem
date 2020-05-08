using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(24)]
    public class CreateEpisodeModel : PageModel
    {
        private ICourseService _courseService;

        public CreateEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }

        public void OnGet(int id)
        {
            SeedCourseEpisode(id);
        }

        public async Task<IActionResult> OnPostAsync(IFormFile fileEpisode)
        {
            if (ModelState.IsValid && fileEpisode != null)
            {
                // user inputs is valid

                if (_courseService.CheckFileExistance(fileEpisode.FileName))
                {
                    // file is repititive
                    ViewData["Failure"] = "نام فایل انتخابی تکراری است.";

                    SeedCourseEpisode(CourseEpisode.CourseId);
                    return Page();
                }

                if (await _courseService.AddEpisodeAsync(CourseEpisode, fileEpisode) > 0)
                {
                    // success
                    TempData["Success"] = "بخش با موفقیت افزوده شد.";
                    return RedirectToPage("Episodes", new { id = CourseEpisode.CourseId });
                }

                // failure
                ViewData["Failure"] = "متاسفانه عملیات افزودن بخش توسط استاد با مشکل روبرو شد.";

                SeedCourseEpisode(CourseEpisode.CourseId);
                return Page();
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";

            SeedCourseEpisode(CourseEpisode.CourseId);
            return Page();
        }

        #region Helpers
        public void SeedCourseEpisode(int id) 
        {
            CourseEpisode = new CourseEpisode();
            CourseEpisode.CourseId = id;
            ViewData["CourseId"] = id;
        }
        #endregion
    }
}