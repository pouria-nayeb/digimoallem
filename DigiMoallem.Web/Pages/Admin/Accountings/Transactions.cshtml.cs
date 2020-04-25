using DigiMoallem.BLL.DTOs.Transactions;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class TransactionsModel : PageModel
    {
        private readonly IOrderService _orderService;

        public TransactionsModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public TransactionPagingViewModel TransactionPagingVM { get; set; }

        public int TransactionsCount { get; set; }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 64)
        {
            TransactionPagingVM = await _orderService.GetAllTransactionsAsync(pageNumber, pageSize);
            TransactionsCount = _orderService.TransactionsCount();
        }
    }
}