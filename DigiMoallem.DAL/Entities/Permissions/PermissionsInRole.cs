using DigiMoallem.DAL.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiMoallem.DAL.Entities.Permissions
{
    public class PermissionsInRole
    {
        [Key]
        public int PermissionsInRoleId { get; set; }

        public int RoleId { get; set; }

        public int PermissionId { get; set; }

        #region Relations - Navigation Properties
        public Role Role { get; set; }
        public Permission Permission { get; set; }
        #endregion
    }
}
