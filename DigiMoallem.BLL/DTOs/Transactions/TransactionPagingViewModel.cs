using DigiMoallem.DAL.Entities.Transactions;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Transactions
{
    public class TransactionPagingViewModel
    {
        public List<Exchange> Exchanges { get; set; }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }
    }
}
