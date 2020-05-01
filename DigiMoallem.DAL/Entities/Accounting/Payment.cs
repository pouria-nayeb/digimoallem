using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Accounting
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Display(Name = "استاد")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int TeacherId { get; set; }

        [Display(Name = "عنوان درس")]
        public int CourseId { get; set; }

        [Display(Name = "مبلغ پرداختی")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int Amount { get; set; }

        [Display(Name = "تاریخ واریز وجه")]
        public DateTime PaymentDate { get; set; }

        #region Relations - Navigation Properties

        [ForeignKey("TeacherId")]
        public User User { get; set; }

        public Course Course { get; set; }

        #endregion
    }
}
