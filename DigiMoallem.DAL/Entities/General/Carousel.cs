using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DigiMoallem.DAL.Entities.General
{
    public class Carousel
    {
        [Key]
        public int CarouselId { get; set; }

        [Display(Name = "تصویر اسلاید")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(75, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string ImageName { get; set; }

        [Display(Name = "توضیحات اسلاید")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Alt { get; set; }

        [Display(Name = "لینک دسترسی")]
        [MaxLength(120, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Url { get; set; }

        [Display(Name = "شناسه اسلاید")]
        public int ImageNumber { get; set; }
    }
}
