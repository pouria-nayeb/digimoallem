using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Courses
{
    public class CourseEpisodesViewModel
    {
        public List<CourseEpisode> Episodes { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
