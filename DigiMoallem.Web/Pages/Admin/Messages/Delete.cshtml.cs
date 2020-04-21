using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.General;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Messages
{
    [PermissionChecker(34)]
    public class DeleteModel : PageModel
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(IMessageService messageService,
            ILogger<DeleteModel> logger)
        {
            _messageService = messageService;
            _logger = logger;
        }

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

        public async Task<IActionResult> OnPostAsync(int id)
        {
            TempData["Success"] = "پیام با موفقیت حذف شد.";
            await _messageService.RemoveContactAsync(id);

            return RedirectToPage("Index");
        }
    }
}