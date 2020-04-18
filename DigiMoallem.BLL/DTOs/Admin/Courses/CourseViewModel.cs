using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Admin.Courses
{
    public class CourseViewModel
    {
        public List<CourseDetailsViewModel> Courses { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
