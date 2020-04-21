using DigiMoallem.DAL.Entities.General;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.General
{
    public class ContactPagingViewModel
    {
        public List<Contact> Contacts { get; set; }

        public int PageCount { get; set; }

        public int PageNumber { get; set; }
    }
}
