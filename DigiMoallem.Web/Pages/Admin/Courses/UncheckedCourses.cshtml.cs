using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(2)]
    public class UncheckedCoursesModel : PageModel
    {
        private ICourseService _courseService;

        public UncheckedCoursesModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CourseViewModel CourseVM { get; set; }

        public int CoursesCount { get; set; }

        public IActionResult OnGet(string title, int pageId = 1)
        {

            if (!string.IsNullOrEmpty(title))
            {
                CourseVM = _courseService.SearchUncheckedCourses(title, pageId);

                return Page();
            }

            CourseVM = _courseService.GetUncheckedCoursesForAdmin(pageId);

            CoursesCount = _courseService.UncheckedCoursesCount();

            return Page();
        }
    }
}