using DigiMoallem.DAL.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class UserCourse
    {
        [Key]
        public int UserCourseId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفاً {0} را انتخاب نمایید.")]
        public int UserId { get; set; }

        [Display(Name = "دوره")]
        [Required(ErrorMessage = "لطفاً {0} را انتخاب نمایید.")]
        public int CourseId { get; set; }

        #region Relations - Navigation Properties

        public User User { get; set; }
        public Course Course { get; set; }

        #endregion
    }
}
