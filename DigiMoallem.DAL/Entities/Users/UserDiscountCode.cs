using DigiMoallem.DAL.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Users
{
    public class UserDiscountCode
    {
        [Key]
        public int UserDiscountCodeId { get; set; }

        public int UserId { get; set; }

        public int DiscountId { get; set; }

        #region Relations - Navigation Properties

        public User User { get; set; }

        public Discount Discount { get; set; }

        #endregion
    }
}
