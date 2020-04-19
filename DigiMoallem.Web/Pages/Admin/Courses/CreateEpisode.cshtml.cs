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
            CourseEpisode = new CourseEpisode();
            CourseEpisode.CourseId = id;
            ViewData["CourseId"] = id;
        }

        public async Task<IActionResult> OnPostAsync(IFormFile fileEpisode)
        {
            if (ModelState.IsValid && fileEpisode != null)
            {
                // user inputs is valid

                if (_courseService.CheckFileExistance(fileEpisode.FileName))
                {
                    // file is repititive
                    TempData["OperationFailed"] = "نام فایل انتخابی تکراری است.";
                    return LocalRedirect($"/Admin/Courses/CreateEpisode/{CourseEpisode.CourseId}");
                }

                if (await _courseService.AddEpisodeAsync(CourseEpisode, fileEpisode) > 0)
                {
                    // success
                    TempData["Success"] = "بخش با موفقیت افزوده شد.";
                    return LocalRedirect($"/Admin/Courses/Episodes/{CourseEpisode.CourseId}");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات افزودن بخش توسط استاد با مشکل روبرو شد.";
                return LocalRedirect($"/Admin/Courses/CreateEpisode/{CourseEpisode.CourseId}");
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return LocalRedirect($"/Admin/Courses/CreateEpisode/{CourseEpisode.CourseId}");
        }
    }
}