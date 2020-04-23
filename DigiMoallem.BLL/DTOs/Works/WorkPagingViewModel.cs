using DigiMoallem.DAL.Entities.General;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Works
{
    public class WorkPagingViewModel
    {
        public List<Work> Works { get; set; }

        public int PageNumber { get; set; }

        public int PageCount { get; set; }
    }
}
