using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Works
{
    [PermissionChecker(37)]
    public class EditModel : PageModel
    {
        private readonly IWorkService _workService;
        private readonly ILogger<EditModel> _logger;

        // step 1: create a constructor
        public EditModel(IWorkService workService,
            ILogger<EditModel> logger)
        {
            // step 2: inject message service
            _workService = workService;
            _logger = logger;
        }

        // step 3: strong-binding
        [BindProperty]
        public Work Work { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Work = await _workService.GetWorkByIdAsync(id.Value);

            if (Work == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _workService.UpdateWorkAsync(Work) != null)
                {
                    // success
                    TempData["Success"] = "درخواست همکاری با موفقیت به روز شد.";

                    return RedirectToPage("Index");
                }
                else 
                {
                    // db failure
                    ViewData["Message"] = "بروز خطا در پایگاه داده، موارد را به توسعه دهنده گزارش دهید.";

                    _logger.LogError($"Message {nameof(EditModel)} database error.");

                    return Page();
                }
            }

            // wrong inputs
            ViewData["Message"] = "ورودی نامعتبر.";

            _logger.LogError($"Message {nameof(EditModel)} database error.");

            return Page();
        }

    }
}