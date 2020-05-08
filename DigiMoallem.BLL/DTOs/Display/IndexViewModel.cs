using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Display
{
    public class IndexViewModel
    {
        public List<Group> Groups { get; set; }

        public List<DisplayCourseViewModel> LatestCourses { get; set; }

        public List<DisplayCourseViewModel> LatestFavoriteCourses { get; set; }
    }
}
