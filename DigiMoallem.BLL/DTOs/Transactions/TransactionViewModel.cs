using System;

namespace DigiMoallem.BLL.DTOs.Transactions
{
    public class TransactionViewModel
    {
        public int Amount { get; set; }
        public int TransactionType { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
