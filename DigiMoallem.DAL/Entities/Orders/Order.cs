using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Orders
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        public bool IsFinally { get; set; }

        [Display(Name = "صندوق")]
        public int? BoxId { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        #region Relations - Navigation Properties

        public virtual User User { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Box Box { get; set; }

        #endregion
    }
}
