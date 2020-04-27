using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> OnGetAsync(string email, int pageNumber = 1, int pageSize = 32)
        {
            if (!string.IsNullOrEmpty(email))
            {
                UserCourseVM = await _orderService.SearchUserCoursesAsync(email, pageNumber, pageSize);

                return Page();
            }

            UserCourseVM = await _orderService.GetAllUserCoursesAsync(pageNumber, pageSize);

            return Page();
        }
    }
}