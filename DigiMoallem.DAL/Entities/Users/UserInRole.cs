using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Users
{
    public class UserInRole
    {
        public UserInRole()
        {

        }

        [Key]
        public int UserInRoleId { get; set; }

        #region ForeginKeys

        public int UserId { get; set; }

        public int RoleId { get; set; }

        #endregion

        #region Relations - Navigation Properties

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }

        #endregion
    }
}
