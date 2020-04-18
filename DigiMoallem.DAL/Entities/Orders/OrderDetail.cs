using DigiMoallem.DAL.Entities.Courses;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Orders
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public int Price { get; set; }

        #region Relations - Navigation Properties

        public Order Order { get; set; }

        public Course Course { get; set; }

        #endregion
    }
}
