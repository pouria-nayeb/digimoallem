using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    public class EditModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<EditModel> _logger;

        public EditModel(IOrderService orderService,
            ILogger<EditModel> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Order = await _orderService.GetOrderByIdAsync(id.Value);

            if (Order == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (ModelState.IsValid)
            {
                if (await _orderService.UpdateOrderAsync(Order))
                {
                    TempData["Success"] = "سفارش با موفقیت ویرایش شد.";

                    return RedirectToPage("All");
                }
                else 
                {
                    ViewData["Message"] = "متاسفانه عملیات ویرایش سفارش توسط ادمین با شکست روبرو شد";
                    return Page();
                }
            }

            ViewData["Message"] = "ورودی شما نامعتبر است.";

            return Page();
        }
    }
}