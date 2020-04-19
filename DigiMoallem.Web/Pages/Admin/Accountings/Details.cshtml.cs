using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Accounting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    [PermissionChecker(28)]
    public class DetailsModel : PageModel
    {
        private IAccountingService _accountingService;

        public DetailsModel(IAccountingService accountingService)
        {
            _accountingService = accountingService;
        }

        public Payment Payment { get; private set; }

        public async Task OnGetAsync(int id)
        {
            Payment = await _accountingService.GetPaymentByIdAsync(id);
            ViewData["TeacherIncomePerCourse"] = await _accountingService.TeacherIncomePerCourseAsync(Payment.TeacherId, Payment.CourseId);

            ViewData["TeacherRemaningPayment"] = await _accountingService.TeacherRemainPaymentAsync(Payment.TeacherId, Payment.CourseId);
        }
    }
}