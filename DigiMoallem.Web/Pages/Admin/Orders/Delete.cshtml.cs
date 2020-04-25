using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    [PermissionChecker(43)]
    public class DeleteModel : PageModel
    {
        private readonly IOrderService _orderService;

        public DeleteModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public UserCourse UserCourse { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            UserCourse = await _orderService.GetUserCourseByIdAsync(id);

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            TempData["Success"] = "سفارش با موفقیت حذف شد.";
            _orderService.RemoveUserCourse(id);

            return RedirectToPage("Index");
        }
    }
}