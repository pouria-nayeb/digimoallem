using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Orders
{
    public class DiscountPerCourse
    {
        [Key]
        public int DiscountPerCourseId { get; set; }

        [Display(Name = "کد تخفیف")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(150)]
        public string DiscountCode { get; set; }

        [Display(Name = "نام درس")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseId { get; set; }

        [Display(Name = "درصد تخفیف")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int DiscountPercent { get; set; }

        [Display(Name = "تعداد کدهای تخفیف")]
        public int? UsableCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        #region Relations - Navigation Properties

        public Course Course { get; set; }

        public List<UserDiscountCode> UserDiscountCodes { get; set; }

        #endregion
    }
}
