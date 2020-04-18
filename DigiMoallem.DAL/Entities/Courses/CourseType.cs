using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.Courses
{
    public class CourseType
    {
        [Key]
        public int CourseTypeId { get; set; }

        [Display(Name = "نوع دوره")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        #region Relations - Navigation Properties

        public List<Course> Courses { get; set; }

        #endregion
    }
}
