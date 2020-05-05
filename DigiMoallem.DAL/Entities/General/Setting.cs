using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiMoallem.DAL.Entities.General
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }

        [Display(Name = "تلفن های تماس")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "پست الکترونیک")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Email { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Address { get; set; }

        [Display(Name = "متن فوتر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Footer { get; set; }

        [Display(Name = "همکاری با دیجی معلم")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string ContributeDigiMoallem { get; set; }

        [Display(Name = "فایل های مورد نیاز")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Files { get; set; }

        [Display(Name = "استانداردهای دیجی معلم")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Standards { get; set; }

        [Display(Name = "قوانین تولید")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string ProductionRules { get; set; }

        [Display(Name = "قوانین و مقررات")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Rules { get; set; }
    }
}
