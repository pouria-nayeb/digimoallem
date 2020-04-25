using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    [PermissionChecker(43)]
    public class DeleteUserCourseModel : PageModel
    {
        private readonly IOrderService _orderService;

        public DeleteUserCourseModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public Order Order { get; set; }

        public IActionResult OnGet(int id)
        {
            Order = _orderService.GetOrderById(id);

            return Page();
        }

        public IActionResult OnPost(int id) 
        {
            _orderService.RemoveOrder(id);

            return RedirectToPage("All");
        }
    }
}