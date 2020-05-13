using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Courses
{
    public class CommentPagingViewModel
    {
        public List<Comment> Comments { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
