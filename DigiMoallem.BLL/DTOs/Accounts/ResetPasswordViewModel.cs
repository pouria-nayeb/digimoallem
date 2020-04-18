using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Accounts
{
    public class ResetPasswordViewModel
    {
        public string ActivationCode { get; set; }

        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [Compare("Password", ErrorMessage = "رمز عبور با تکرار رمز عبور مغایرت دارد.")]
        public string ConfirmPassword { get; set; }
    }
}
