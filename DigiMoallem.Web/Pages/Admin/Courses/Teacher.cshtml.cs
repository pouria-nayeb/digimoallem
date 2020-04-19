using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(23)]
    public class TeacherModel : PageModel
    {
            private ICourseService _courseService;

            public TeacherModel(ICourseService courseService)
            {
                _courseService = courseService;
            }

            public CourseViewModel CourseVM { get; set; }

            public async Task OnGetAsync(int pageId = 1)
            {
                CourseVM = await _courseService.GetCoursesForAdminAsync(pageId);
            }
    }
}