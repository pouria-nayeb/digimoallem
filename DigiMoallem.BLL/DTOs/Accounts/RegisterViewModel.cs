﻿using DigiMoallem.DAL.Entities.Courses;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Accounts
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد.")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "لطفاً ایمیل معتبر وارد کنید.")]
        public string Email { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        [MinLength(5, ErrorMessage = "{0} نمی تواند از {1} کاراکتر کمتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار رمز عبور مغایرت دارد.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "گروه های علاقه مندی")]
        [Required(ErrorMessage = "لطفاً حداقل یک {0} را انتخاب نمایید.")]
        public int GroupId { get; set; }
    }
}
