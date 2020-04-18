using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Users
{
    public class Role
    {
        public Role()
        {

        }

        [Key]
        public int RoleId { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        public bool IsDelete { get; set; }

        #region Relations - Navigation Properties

        public virtual List<UserInRole> UserInRoles { get; set; }

        //public List<PermissionsInRole> PermissionsInRoles { get; set; }

        #endregion
    }
}
