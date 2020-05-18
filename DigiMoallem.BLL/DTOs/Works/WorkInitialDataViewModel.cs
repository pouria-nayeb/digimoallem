using DigiMoallem.DAL.Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiMoallem.BLL.DTOs.Works
{
    public class WorkInitialDataViewModel
    {
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
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [RegularExpression(@"(0|\+98)?([ ]|,|-|[()]){0,2}9[1|2|3|4]([ ]|,|-|[()]){0,2}(?:[0-9]([ ]|,|-|[()]){0,2}){8}", ErrorMessage = "شماره تلفن معتبر وارد نمایید.")] 
        public string Mobile { get; set; }

        [Display(Name = "مقطع تحصیلی")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string EducationalLevel { get; set; }

        [Display(Name = "شماره کارت")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(20, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string CardNumber { get; set; }

        [Display(Name = "شماره شبا")]
        public string Sheba { get; set; }

        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }

        [Display(Name = "رزومه")]
        public string CvTitle { get; set; }

        [DataType(DataType.Upload)]
        [MaxFileSize(1 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".pdf", ".docx", ".doc" })]
        public IFormFile CvFile { get; set; }

        [Display(Name = "تصویر متقاضی")]
        public string AvatarName { get; set; }

        [DataType(DataType.Upload)]
        [MaxFileSize(1 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        public IFormFile AvatarFile { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SubmitDate { get; set; }
    }
}
