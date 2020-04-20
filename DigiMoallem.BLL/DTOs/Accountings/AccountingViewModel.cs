using DigiMoallem.DAL.Entities.Accounting;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class AccountingViewModel
    {
        public List<Payment> Payments { get; set; }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }
    }
}
