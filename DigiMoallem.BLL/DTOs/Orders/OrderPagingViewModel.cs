using DigiMoallem.DAL.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigiMoallem.BLL.DTOs.Orders
{
    public class OrderPagingViewModel
    {
        public List<Order> Orders { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
