using DigiMoallem.DAL.Entities.Orders;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Accounting
{
    public class Box
    {
        [Key]
        public int BoxId { get; set; }

        [Display(Name = "نام صندوق")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        public bool IsActive { get; set; }

        #region Relations - Navigation Properties

        public ICollection<Payment> Payments { get; set; }

        public ICollection<Order> Orders { get; set; }

        #endregion
    }
}
