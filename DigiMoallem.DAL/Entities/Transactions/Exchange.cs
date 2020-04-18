using DigiMoallem.DAL.Entities.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Transactions
{
    public class Exchange
    {
        public Exchange()
        {

        }

        [Key]
        public int ExchangeId { get; set; }

        [Display(Name = "نوع تراکنش")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int TransactionTypeId { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int UserId { get; set; }

        [Display(Name = "مبلغ شارژ")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int Amount { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Description { get; set; }

        [Display(Name = "وضعیت تراکنش")]
        public bool IsPay { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        public DateTime TransactionDate { get; set; }

        #region Relations - Navigation Properties

        public virtual TransactionType TransactionType { get; set; }

        public virtual User User { get; set; }

        #endregion
    }
}
