using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.BLL.DTOs.Works
{
    public class WorkComplementDataViewModel
    {
        public int WorkId { get; set; }

        [Display(Name = "مهارت ها")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Skills { get; set; }

        [Display(Name = "سوابق کاری")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Experiences { get; set; }

        [Display(Name = "زمینه های همکاری")]
        [MaxLength(1500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ContributionFields { get; set; }
    }
}
