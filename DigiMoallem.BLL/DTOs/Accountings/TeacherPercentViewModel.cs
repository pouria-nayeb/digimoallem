using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Accountings
{
    public class TeacherPercentViewModel
    {
        [Display(Name = "درصد استاد")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [Range(0, 100, ErrorMessage = "درصد استاد باید بین 0 تا 100 باشد.")]
        public int Percent { get; set; }

        [Display(Name = "درس")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        public int CourseId { get; set; }
    }
}
