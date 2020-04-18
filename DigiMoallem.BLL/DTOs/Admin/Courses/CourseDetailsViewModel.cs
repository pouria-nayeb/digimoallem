namespace DigiMoallem.BLL.DTOs.Admin.Courses
{
    public class CourseDetailsViewModel
    {
        public int CourseId { get; set; }
        public int TeacherId { get; set; }
        public string Title { get; set; }
        public string Teacher { get; set; }
        public string ImageName { get; set; }
        public int EpisodesCount { get; set; }
    }
}
