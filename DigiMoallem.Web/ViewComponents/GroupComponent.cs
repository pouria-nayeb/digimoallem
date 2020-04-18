using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DigiMoallem.Web.ViewComponents
{
    public class GroupComponent : ViewComponent
    {
        private ICourseService _courseService;

        public GroupComponent(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Group", await _courseService.GetGroupsAsync()));
        }
    }
}
