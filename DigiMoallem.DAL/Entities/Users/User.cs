using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Users
{
    public class User
    {
        public User()
        {

        }

        [Key]
        public int UserId { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string UserName { get; set; }

        [Display(Name = "نام")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string LastName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد.")]
        public string Email { get; set; }

        [Display(Name = "آخرین مدرک")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ScientificField { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Description { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Password { get; set; }

        public int? Balance { get; set; }

        [Display(Name = "کد فعال سازی")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ActivationCode { get; set; }

        [Display(Name = "وضعیت کاربر")]
        public bool IsActive { get; set; }

        [Display(Name = "مهارت ها")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Skills { get; set; }

        [Display(Name = "سابقه کاری")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Experiences { get; set; }

        [Display(Name = "شماره همراه")]
        [MaxLength(12, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "تصویر کاربر")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string UserAvatar { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        public bool IsDelete { get; set; }

        #region Relations - Navigation Properties

        public virtual List<UserInRole> UserInRoles { get; set; }

        public virtual List<Exchange> Exchanges { get; set; }

        public virtual List<Course> Courses { get; set; }

        public virtual List<Order> Orders { get; set; }

        public List<UserCourse> UserCourses { get; set; }

        public List<UserDiscountCode> UserDiscountCodes { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Payment> Payments { get; set; }

        public List<RateCourse> RateCourses { get; set; }

        public List<LikeCourse> LikeCourses { get; set; }

        #endregion
    }
}
