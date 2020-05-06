using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DigiMoallem.Web.Pages.Admin.Standards
{
    [PermissionChecker(45)]
    public class CreateModel : PageModel
    {
        private readonly IStandardService _standardService;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(IStandardService standardService,
            ILogger<CreateModel> logger)
        {
            _standardService = standardService;
            _logger = logger;
        }

        [BindProperty]
        public Standard Standard { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                if (_standardService.AddStandard(Standard) != null)
                {
                    // success
                    TempData["Success"] = "استاندارد با موفقیت افزوده شد.";
                    return RedirectToPage("Index");
                }
                else 
                {
                    // db error
                    ViewData["Failure"] = "متاسفانه عملیات افزودن استاندارد توسط ادمین با مشکل روبرو شد.";
                    return Page();
                }
            }

            // admin inputs not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}