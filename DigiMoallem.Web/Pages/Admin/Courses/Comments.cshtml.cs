using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    public class CommentsModel : PageModel
    {
        private readonly ICourseService _courseService;

        public CommentsModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public CommentPagingViewModel CommentPagingVM { get; set; }

        public int CommentsCount { get; set; }

        public void OnGet(int pageNumber = 1, int pageSize = 32)
        {
            CommentPagingVM = _courseService.GetAllCommentsToManage(pageNumber, pageSize);
            CommentsCount = _courseService.CommentsCount();
        }
    }
}