using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Blog
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "عنوان گروه")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "تصویر")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ImageName { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsDelete { get; set; }

        [Display(Name = "گروه اصلی")]
        public int? ParentId { get; set; }

        #region Relations - Navigation Properties

        [ForeignKey("ParentId")]
        public List<Category> Categories { get; set; }

        [InverseProperty("Category")]
        public List<Article> Articles { get; set; }

        [InverseProperty("SubCategory")]
        public List<Article> SubArticles { get; set; }

        #endregion
    }
}
