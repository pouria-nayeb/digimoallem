using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Works
{
    [PermissionChecker(38)]
    public class DeleteModel : PageModel
    {
        private readonly IWorkService _workService;
        private readonly ILogger<DeleteModel> _logger;

        // step 1: create a constructor
        public DeleteModel(IWorkService workService,
            ILogger<DeleteModel> logger)
        {
            // step 2: inject message service
            _workService = workService;
            _logger = logger;
        }

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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            TempData["Success"] = "پیام با موفقیت حذف شد.";
            await _workService.RemoveWorkAsync(id);

            return RedirectToPage("Index");
        }
    }
}