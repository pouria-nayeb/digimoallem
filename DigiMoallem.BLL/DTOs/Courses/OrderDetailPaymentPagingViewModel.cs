using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Courses
{
    public class OrderDetailPaymentPagingViewModel
    {
        public List<OrderDetailPaymentViewModel> OrderDetailPayments { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }

        public int TotalOrderDetailsPayments { get; set; }
    }
}
