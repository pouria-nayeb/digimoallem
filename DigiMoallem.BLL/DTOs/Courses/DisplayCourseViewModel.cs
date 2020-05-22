using System;

namespace DigiMoallem.BLL.DTOs.Courses
{
    public class DisplayCourseViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string GroupName { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
        public bool Off { get; set; }
        public byte? OffPercentage { get; set; }
        public int? PriceAfterOff { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
