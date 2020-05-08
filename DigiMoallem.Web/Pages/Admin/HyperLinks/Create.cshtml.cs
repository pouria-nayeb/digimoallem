using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DigiMoallem.Web.Pages.Admin.HyperLinks
{
    [PermissionChecker(47)]
    public class CreateModel : PageModel
    {
        private readonly IHyperLinkService _hyperLinkService;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(IHyperLinkService hyperLinkService,
            ILogger<CreateModel> logger)
        {
            _hyperLinkService = hyperLinkService;
            _logger = logger;
        }

        [BindProperty]
        public UploadLink UploadLink { get; set; }

        public IFormFile Image { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                if (_hyperLinkService.AddHyperLink(UploadLink, Image) != null)
                {
                    TempData["Success"] = "فایل با موفقیت افزوده شد.";
                    return RedirectToPage("Index");
                }
                else 
                {
                    TempData["OperationFailed"] = "متاسفانه عملیات افزودن نقش توسط ادمین با مشکل روبرو شد.";
                    return Page();
                }
            }

            ViewData["Failure"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}