using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(23)]
    public class TeacherModel : PageModel
    {
        private ICourseService _courseService;
        private readonly IUserService _userService;

        public TeacherModel(ICourseService courseService, IUserService userService)
        {
            _courseService = courseService;
            _userService = userService;
        }

        public CourseViewModel CourseVM { get; set; }

        public void OnGetAsync(int pageId = 1)
        {
            int teacherId = _userService.GetUserIdByUserName(User.Identity.Name);
            CourseVM = _courseService.GetTeacherCoursesForAdminAsync(pageId, teacherId);
        }
    }
}