using DigiMoallem.DAL.Entities.Orders;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Admin.Discounts
{
    public class DiscountPerCourseViewModel
    {
        public List<DiscountPerCourse> Discounts { get; set; }
        public int PageNumber { get; set; }
        public int PagesCount { get; set; }
    }
}
