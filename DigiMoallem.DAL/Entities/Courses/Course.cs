using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int GroupId { get; set; }

        [Display(Name = "زیرگروه")]
        public int? SubGroupId { get; set; }

        [Display(Name = "استاد")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int TeacherId { get; set; }

        [Display(Name = "سطح دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseLevelId { get; set; }

        [Display(Name = "وضعیت دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseStatusId { get; set; }

        [Display(Name = "عنوان دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "شرح دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Description { get; set; }

        [Display(Name = "تصویر دوره")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ImageName { get; set; }

        [Display(Name = "قیمت")]
        public int Price { get; set; }

        [Display(Name = "برچسب ها")]
        [MaxLength(350, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Tags { get; set; }

        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Demo { get; set; }

        [Display(Name = "مخفی سازی دوره")]
        public bool IsHidden { get; set; }

        [Display(Name = "نمایش پیام ها")]
        public bool DisplayComment { get; set; }

        [Display(Name = "در انتظار تایید")]
        public bool IsCheckedByAdmin { get; set; }

        [Display(Name = "دوره برگزیده")]
        public bool? IsFavorite { get; set; }

        [Display(Name = "درآمد کل")]
        public int? TotalIncome { get; set; }

        [Display(Name = "مجموع پرداختی ها")]
        public int? TotalPayment { get; set; }

        public int? TotalInstitutePayment { get; set; }

        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        #region Relations - Navigation Properties

        [ForeignKey("TeacherId")]
        public User User { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        [Display(Name = "درصد استاد")]
        [Range(0, 100, ErrorMessage = "درصد استاد باید بین 0 تا 100 باشد.")]
        public int? TeacherPercent { get; set; }

        [ForeignKey("SubGroupId")]
        public Group SubGroup { get; set; }

        [ForeignKey("CourseLevelId")]
        public CourseLevel CourseLevel { get; set; }

        [ForeignKey("CourseStatusId")]
        public CourseStatus CourseStatus { get; set; }

        public List<CourseEpisode> CourseEpisodes { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<UserCourse> UserCourses { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Payment> Payments { get; set; }

        public List<RateCourse> RateCourses { get; set; }

        public List<LikeCourse> LikeCourses { get; set; }

        public List<CourseInCourseType> CourseInCourseTypes { get; set; }

        #endregion
    }
}
