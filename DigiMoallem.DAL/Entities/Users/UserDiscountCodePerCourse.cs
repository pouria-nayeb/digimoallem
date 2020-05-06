using DigiMoallem.DAL.Entities.Orders;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Users
{
    public class UserDiscountCodePerCourse
    {
        [Key]
        public int UserDiscountCodePerCourseId { get; set; }

        public int UserId { get; set; }

        public int DiscountPerCourseId { get; set; }

        #region Relations - Navigation Properties

        public User User { get; set; }

        public DiscountPerCourse DiscountPerCourse { get; set; }

        #endregion
    }
}
