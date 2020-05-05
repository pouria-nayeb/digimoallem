using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Settings
{
    public class EditModel : PageModel
    {
        private readonly ISettingService _settingService;

        public EditModel(ISettingService settingService)
        {
            _settingService = settingService;
        }

        [BindProperty]
        public Setting Setting { get; set; }

        public void OnGet()
        {
            Setting = _settingService.GetSettingById(1);
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                if (_settingService.UpdateSetting(Setting) != null)
                {
                    TempData["Success"] = "تنظیمات با موفقیت ویرایش شد.";


                    return RedirectToPage("Edit");
                }
                else 
                {
                    ViewData["Failure"] = "متاسفانه عملیات ویرایش نقش توسط ادمین با مشکل روبرو شد.";

                    return Page();
                }
            }

            ViewData["Failure"] = "ورودی شما نامعتبر است.";

            return Page();
        }
    }
}