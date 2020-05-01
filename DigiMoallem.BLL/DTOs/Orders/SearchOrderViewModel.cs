using DigiMoallem.DAL.Entities.Orders;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Orders
{
    public class SearchOrderViewModel
    {
        public List<OrderDetail> OrderDetails { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }

        public int TotalPayment { get; set; }
    }
}
