using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Orders
{
    public class UserCoursePagingViewModel
    {
        public List<UserCourse> UserCourses { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
