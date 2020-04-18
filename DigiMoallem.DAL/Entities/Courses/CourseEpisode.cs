using System;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class CourseEpisode
    {
        [Key]
        public int CourseEpisodeId { get; set; }

        [Display(Name = "عنوان دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseId { get; set; }

        [Display(Name = "عنوان بخش")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(350, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "زمان")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public TimeSpan EpisodeLength { get; set; }

        [Display(Name = "فایل")]
        [MaxLength(350, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string EpisodeFileName { get; set; }

        [Display(Name = "رایگان")]
        public bool IsFree { get; set; }

        [Display(Name = "در انتظار تایید")]
        public bool IsCheckedByAdmin { get; set; }

        #region Relations - Navigation Properties

        public Course Course { get; set; }

        #endregion
    }
}
