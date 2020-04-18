using DigiMoallem.DAL.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class RateCourse
    {
        [Key]
        public int RateCourseId { get; set; }

        public int CourseId { get; set; }

        public int UserId { get; set; }

        [Range(1, 5, ErrorMessage = "امتیاز دوره باید بین 1 تا 5 باشد.")]
        public byte? Rate { get; set; }

        #region Relations - Navigation Properties

        public Course Course { get; set; }

        public User User { get; set; }

        #endregion
    }
}
