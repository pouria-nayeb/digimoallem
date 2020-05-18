using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Accounts
{
    public class LoginRandomTokenViewModel
    {
        [Display(Name = "رمز یکبار مصرف")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Token { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}
