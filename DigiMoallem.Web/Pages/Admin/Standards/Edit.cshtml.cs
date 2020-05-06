using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DigiMoallem.Web.Pages.Admin.Standards
{
    [PermissionChecker(45)]
    public class EditModel : PageModel
    {
        private readonly IStandardService _standardService;
        private readonly ILogger<EditModel> _logger;

        public EditModel(IStandardService standardService,
            ILogger<EditModel> logger)
        {
            _standardService = standardService;
            _logger = logger;
        }

        [BindProperty]
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

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (_standardService.UpdateStandard(Standard) != null)
                {
                    // success
                    TempData["Success"] = "استاندارد با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }
                else
                {
                    // db error
                    return DisplayFailureNotification("متاسفانه عملیات افزودن استاندارد توسط ادمین با مشکل روبرو شد.");
                }
            }

            // admin inputs not valid
            return DisplayFailureNotification("ورودی شما نامعتبر است.");
        }

        private IActionResult DisplayFailureNotification(string message) 
        {
            ViewData["Failure"] = message;
            return Page();
        }
    }
}