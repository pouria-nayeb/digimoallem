using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(2)]
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CourseViewModel CourseVM { get; set; }

        public int CoursesCount { get; set; }

        public async Task<IActionResult> OnGetAsync(string title, int pageId = 1)
        {

            if (!string.IsNullOrEmpty(title))
            {
                CourseVM = await _courseService.SearchCoursesAsync(title, pageId);

                return Page();
            }

            CourseVM = await _courseService.GetCoursesForAdminAsync(pageId);

            CoursesCount = await _courseService.CoursesCountAsync();

            return Page();
        }
    }
}