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
        public IFormFile UserAvatar { get; set; }
        public string ImageName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string PhoneNumber { get; set; }
    }
}
