using DigiMoallem.DAL.Entities.Users;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigiMoallem.DAL.Entities.Blog
{
    public class Article
    {
        [Key]
        public int CourseId { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CategoryId { get; set; }

        [Display(Name = "زیرگروه")]
        public int? SubCategoryId { get; set; }

        [Display(Name = "نویسنده")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int AuthorId { get; set; }

        [Display(Name = "عنوان مقاله")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "متن مقاله")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public string Body { get; set; }

        [Display(Name = "تصویر مقاله")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ImageName { get; set; }

        [Display(Name = "برچسب ها")]
        [MaxLength(350, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Tags { get; set; }

        [Display(Name = "مخفی سازی دوره")]
        public bool IsHidden { get; set; }

        [Display(Name = "نمایش پیام ها")]
        public bool DisplayComment { get; set; }

        [Display(Name = "در انتظار تایید")]
        public bool IsCheckedByAdmin { get; set; }

        [Display(Name = "دوره برگزیده")]
        public bool IsFavorite { get; set; }

        #region Relations - Navigation Properties

        [ForeignKey("AuthorId")]
        public User User { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("SubCategoryId")]
        public Category SubCategory { get; set; }

        public List<ArticleComment> ArticleComments { get; set; }

        #endregion
    }
}
