using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DigiMoallem.Web.Pages.Admin.Standards
{
    [PermissionChecker(45)]
    public class DeleteModel : PageModel
    {
        private readonly IStandardService _standardService;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(IStandardService standardService,
            ILogger<DeleteModel> logger)
        {
            _standardService = standardService;
            _logger = logger;
        }

        public Standard Standard { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Standard = _standardService.GetStandardById(id.Value);

            if (Standard == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _standardService.RemoveStandard(id);

            TempData["Success"] = "استاندارد با موفقیت حذف شد.";
            return RedirectToPage("Index");
        }
    }
}