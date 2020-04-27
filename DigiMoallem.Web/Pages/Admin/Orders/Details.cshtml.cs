using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly IOrderService _orderService;

        public DetailsModel(IOrderService orderService)
        {
           _orderService = orderService;
        }

        public Order Order { get; private set; }

        public async Task OnGetAsync(int id)
        {
            Order = await _orderService.GetOrderByIdAsync(id);
        }
    }
}