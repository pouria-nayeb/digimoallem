using DigiMoallem.DAL.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class LikeCourse
    {
        [Key]
        public int LikeCourseId { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        public bool Like { get; set; }

        #region Relation - Naviation Properties

        public User User { get; set; }

        public Course Course { get; set; }

        #endregion
    }
}
