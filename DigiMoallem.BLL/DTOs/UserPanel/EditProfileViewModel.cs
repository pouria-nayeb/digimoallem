using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.UserPanel
{
    public class EditProfileViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Email { get; set; }

        [Display(Name = "نام")]
        [MaxLength(75, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(75, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string LastName { get; set; }

        [Display(Name = "درباره مدرس")]
        public string Description { get; set; }

        [Display(Name = "مهارت ها")]
        public string Skills { get; set; }

        [Display(Name = "رشته")]
        public string ScientificField { get; set; }

        [Display(Name = "مقطع تحصیلی")]
        public string EducationalLevel { get; set; }

        [Display(Name = "شماره کارت")]
        public string CardNumber { get; set; }

        [Display(Name = "شماره شبا")]
        public string Sheba { get; set; }

        public string Experiences { get; set; }

        public IFormFile UserAvatar { get; set; }

        public string ImageName { get; set; }

        [Display(Name = "تلفن همراه")]
        public string PhoneNumber { get; set; }
    }
}
