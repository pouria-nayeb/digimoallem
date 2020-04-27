using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class TeacherShareViewModel
    {
        public List<Course> Courses { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
