using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Accounting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Purifications
{
    [PermissionChecker(50)]
    public class EditModel : PageModel
    {
        private readonly IAccountingService _accountingService;

        public EditModel(IAccountingService accountingService)
        {
            _accountingService = accountingService;
        }

        [BindProperty]
        public Purification Purification { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Purification = _accountingService.GetPurificationById(id.Value);

            if (Purification == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid)
            {
                if (_accountingService.UpdatePurification(Purification) != null)
                {
                    TempData["Success"] = "درخواست تصفیه بررسی شد.";

                    return RedirectToPage("Index");
                }
                else 
                {
                    ViewData["Failure"] = "عملیات بررسی درخواست تصفیه با مشکل روبرو شد، لطفاً موارد را به مدیریت اطلاع دهید.";

                    return Page();
                }
            }

            ViewData["Failure"] = "ورودی نامعتبر.";

            return Page();
        }
    }
}