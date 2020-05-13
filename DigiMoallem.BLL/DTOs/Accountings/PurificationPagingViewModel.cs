using DigiMoallem.DAL.Entities.Accounting;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class PurificationPagingViewModel
    {
        public List<Purification> Purifications { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
