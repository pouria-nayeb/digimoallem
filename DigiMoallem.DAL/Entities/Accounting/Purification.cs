using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Accounting
{
    public class Purification
    {
        [Key]
        public int PurificationId { get; set; }

        [Display(Name = "نام استاد")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int TeacherId { get; set; }

        [Display(Name = "نام دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseId { get; set; }

        [Display(Name = "مبلغ")]
        public long Amount { get; set; }

        [Display(Name = "بررسی تصفیه حساب")]
        public bool IsChecked { get; set; }

        public DateTime SubmitDate { get; set; }

        #region Relations - Navigation Properties
        [ForeignKey("TeacherId")]
        public User User { get; set; }

        public Course Course { get; set; }
        #endregion
    }
}
