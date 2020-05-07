using DigiMoallem.DAL.Entities.General;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.HyperLink
{
    public class HyperLinkViewModel
    {
        public List<UploadLink> UploadLinks { get; set; }

        public int PageNumber { get; set; }

        public int PagesCount { get; set; }
    }
}
