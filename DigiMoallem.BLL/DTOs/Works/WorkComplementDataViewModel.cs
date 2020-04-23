using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Works
{
    public class WorkComplementDataViewModel
    {
        [Display(Name = "مهارت ها")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Skills { get; set; }

        [Display(Name = "تجربیات")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Experiences { get; set; }
    }
}
