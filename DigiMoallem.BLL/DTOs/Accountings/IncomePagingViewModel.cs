using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class IncomePagingViewModel
    {
        public List<IncomesViewModel> Incomes { get; set; }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }
    }
}
