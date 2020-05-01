using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class TeacherStatisticsModel : PageModel
    {
        private readonly ICourseService _courseService;

        public TeacherStatisticsModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CourseViewModel CourseVM { get; set; }

        public void OnGet(int pageId = 1)
        {
            CourseVM = _courseService.GetCoursesForAdmin(pageId);
        }
    }
}