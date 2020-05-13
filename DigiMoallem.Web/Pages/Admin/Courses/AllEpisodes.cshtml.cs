using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(2)]
    public class AllEpisodesModel : PageModel
    {
        private readonly ICourseService _courseService;

        public AllEpisodesModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CourseEpisodesViewModel CourseEpisodesVM { get; set; }

        public int UncheckedEpisodesCount { get; set; }

        public void OnGet(int pageNumber = 1, int pageSize = 32)
        {
            CourseEpisodesVM = _courseService.GetAllUncheckedEpisodes(pageNumber, pageSize);
            UncheckedEpisodesCount = _courseService.UncheckedEpisodesCount();
        }
    }
}