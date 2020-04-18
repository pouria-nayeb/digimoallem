﻿using System;

namespace DigiMoallem.BLL.DTOs.UserPanel
{
    public class UserPanelViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public int Balance { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageName { get; set; }
    }
}