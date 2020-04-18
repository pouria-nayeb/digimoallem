using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Permissions
{
    public class Permission
    {
        [Key]
        public int PermissionId { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        public int? ParentId { get; set; }

        #region Relations - Navigation Properties
        [ForeignKey("ParentId")]
        public List<Permission> Permissions { get; set; }
        public List<PermissionsInRole> PermissionsInRoles { get; set; }
        #endregion
    }
}
