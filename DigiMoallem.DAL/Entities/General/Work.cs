using System;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.General
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(75, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(75, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string LastName { get; set; }

        [Display(Name = "پست الکترونیک")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Email { get; set; }

        [Display(Name = "تلفن ثابت")]
        [MaxLength(12, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "تلفن همراه")]
        [MaxLength(12, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Mobile { get; set; }

        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }

        [Display(Name = "لینک رزومه")]
        public string CvTitle { get; set; }

        [Display(Name = "تصویر متقاضی")]
        public string AvatarName { get; set; }

        [Display(Name = "شماره کارت")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string CardNumber { get; set; }

        [Display(Name = "شماره شبا")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Sheba { get; set; }

        [Display(Name = "مقطع آموزشی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string EducationalLevel { get; set; }

        [Display(Name = "بررسی شده")]
        public bool IsChecked { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SubmitDate { get; set; }

        [Display(Name = "زمینه های همکاری")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ContributionFields { get; set; }

        [Display(Name = "مهارت ها")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Skills { get; set; }

        [Display(Name = "تجربیات")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Experiences { get; set; }
    }
}
