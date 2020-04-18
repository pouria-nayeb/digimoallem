using DigiMoallem.DAL.Entities.Users;
using System.Collections.Generic;

namespace DigiMoallem.BLL.DTOs.Admin.Users
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
