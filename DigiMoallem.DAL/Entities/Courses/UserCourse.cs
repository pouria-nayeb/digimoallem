using DigiMoallem.DAL.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class UserCourse
    {
        [Key]
        public int UserCourseId { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        #region Relations - Navigation Properties

        public User User { get; set; }
        public Course Course { get; set; }

        #endregion
    }
}
