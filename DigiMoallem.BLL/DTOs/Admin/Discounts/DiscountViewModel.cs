using DigiMoallem.DAL.Entities.Orders;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Admin.Discounts
{
    public class DiscountViewModel
    {
        public List<Discount> Discounts { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
