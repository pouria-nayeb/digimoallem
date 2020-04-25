using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    [PermissionChecker(40)]
    public class IndexModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IOrderService orderService,
            ILogger<IndexModel> logger)
        {
            _orderService = orderService;
            _logger = logger;
        }

        public UserCoursePagingViewModel UserCourseVM { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 32)
        {
            UserCourseVM = await _orderService.GetAllUserCoursesAsync(pageNumber, pageSize);
        }
    }
}