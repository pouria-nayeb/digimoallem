using DigiMoallem.DAL.Entities.Users;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class UserGroup
    {
        [Key]
        public int UserGroupId { get; set; }

        [Display(Name = "کاربر")]
        public int UserId { get; set; }

        [Display(Name = "گروه ها")]
        public int GroupId { get; set; }

        #region Relations - Navigation Properties

        public User User { get; set; }

        public Group Group { get; set; }

        #endregion
    }
}
