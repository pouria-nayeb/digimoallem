using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    //[PermissionChecker(23)]
    public class EpisodesModel : PageModel
    {
        private ICourseService _courseService;

        public EpisodesModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<CourseEpisode> CourseEpisodes { get; set; }

        public async Task OnGetAsync(int id)
        {
            ViewData["CourseId"] = id;
            CourseEpisodes = await _courseService.GetEpisodesAsync(id);
        }
    }
}