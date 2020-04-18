using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Groups
{
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;
        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<Group> Groups { get; set; }

        public async Task OnGetAsync()
        {
            Groups = await _courseService.GetGroupsAsync();
        }
    }
}