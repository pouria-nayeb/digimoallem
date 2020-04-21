using System;
using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.General
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Display(Name = "تلفن تماس")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "متن پیام")]
        [Required(ErrorMessage = "لطفاً {0} را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Description { get; set; }

        [Display(Name = "بررسی شده؟")]
        public bool IsChecked { get; set; }

        [Display(Name = "تاریخ درج پیام")]
        [DataType(DataType.Date)]
        public DateTime SubmitDate { get; set; }
    }
}
