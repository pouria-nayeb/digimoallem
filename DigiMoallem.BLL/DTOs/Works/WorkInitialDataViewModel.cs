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
        [MaxLength(12, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Mobile { get; set; }

        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }

        [Display(Name = "رزومه")]
        public string CvTitle { get; set; }

        public IFormFile CvFile { get; set; }

        [Display(Name = "تصویر متقاضی")]
        public string AvatarName { get; set; }

        public IFormFile AvatarFile { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SubmitDate { get; set; }
    }
}
