using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    [PermissionChecker(40)]
    public class AllModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<AllModel> _logger;

        public AllModel(IOrderService orderService,
            ILogger<AllModel> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        public OrderPagingViewModel OrderPagingVM { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 32)
        {
            OrderPagingVM = await _orderService.GetAllOrdersAsync(pageNumber, pageSize);
        }
    }
}