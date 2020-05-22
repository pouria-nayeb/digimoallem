using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.General
{
    public class Advertise
    {
        [Key]
        public int AdvertiseId { get; set; }

        [Display(Name = "عکس تبلیغ")] 
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ImageName { get; set; }

        [Display(Name = "عنوان تبلیغ")] 
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "آدرس دسترسی")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Url { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(500, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Description { get; set; }

        public AdvertisePage AdvertisePage { get; set; }
    }

    public enum AdvertisePage 
    { 
        Blog = 1,
        Course = 2
    }
}
