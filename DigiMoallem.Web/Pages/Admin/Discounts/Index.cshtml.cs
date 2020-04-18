using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Discounts
{
    public class IndexModel : PageModel
    {
        private IOrderService _orderService;

        public IndexModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public DiscountViewModel DiscountViewModel { get; set; }

        public async Task OnGetAsync(int pageId = 1)
        {
            DiscountViewModel = await _orderService.GetDiscountsAsync(pageId);
        }
    }
}