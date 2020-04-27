using DigiMoallem.DAL.Entities.Accounting;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class TeacherPaymentViewModel
    {
        public List<Payment> Payments { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
