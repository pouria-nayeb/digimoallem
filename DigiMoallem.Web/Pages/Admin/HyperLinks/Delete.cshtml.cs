using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DigiMoallem.Web.Pages.Admin.HyperLinks
{
    [PermissionChecker(48)]
    public class DeleteModel : PageModel
    {
        private readonly IHyperLinkService _hyperLinkService;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(IHyperLinkService hyperLinkService,
            ILogger<DeleteModel> logger)
        {
            _hyperLinkService = hyperLinkService;
            _logger = logger;
        }

        public UploadLink UploadLink { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            UploadLink = _hyperLinkService.GetHyperLinkById(id.Value);

            if (UploadLink == null)
            {
                return BadRequest();
            }

            return Page();
        }

        public IActionResult OnPost(int id) 
        {
            _hyperLinkService.RemoveHyperLink(id);
            TempData["Success"] = "فایل با موفقیت حذف شد.";

            return RedirectToPage("Index");
        }
    }
}