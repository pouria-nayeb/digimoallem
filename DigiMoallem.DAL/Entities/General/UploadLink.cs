using System.ComponentModel.DataAnnotations;

namespace DigiMoallem.DAL.Entities.General
{
    public class UploadLink
    {
        [Key]
        public int UploadLinkId { get; set; }

        [Display(Name = "توضیحات فایل")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Name { get; set; }

        [Display(Name = "فایل")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string FileTitle { get; set; }

        [Display(Name = "لینک فایل")] 
        [MaxLength(200, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد.")]
        public string Url { get; set; }
    }
}
