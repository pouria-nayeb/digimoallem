using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Transactions
{
    public class ChargeAccountViewModel
    {
        [Display(Name = "مبلغ شارژ")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int Amount { get; set; }
    }
}
