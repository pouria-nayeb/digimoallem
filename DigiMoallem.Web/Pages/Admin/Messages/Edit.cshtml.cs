using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Messages
{
    [PermissionChecker(33)]
    public class EditModel : PageModel
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<EditModel> _logger;

        // step 1: create a constructor
        public EditModel(IMessageService messageService,
            ILogger<EditModel> logger)
        {
            // step 2: inject message service
            _messageService = messageService;
            _logger = logger;
        }

        // step 3: strong-binding
        [BindProperty]
        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Contact = await _messageService.GetContactByIdAsync(id.Value);

            if (Contact == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _messageService.UpdateContactAsync(Contact) != null)
                {
                    // success
                    TempData["Success"] = "پیام با موفقیت به روز شد.";

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