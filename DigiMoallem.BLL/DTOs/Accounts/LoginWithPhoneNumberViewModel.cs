using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Accounts
{
    public class LoginWithPhoneNumberViewModel
    {
        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [RegularExpression(@"(0|\+98)?([ ]|,|-|[()]){0,2}9[1|2|3|4]([ ]|,|-|[()]){0,2}(?:[0-9]([ ]|,|-|[()]){0,2}){8}", ErrorMessage = "شماره تلفن معتبر وارد نمایید.")]
        public string PhoneNumber { get; set; }
    }
}
