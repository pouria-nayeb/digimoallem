using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Discounts
{
    [PermissionChecker(20)]
    public class CreateModel : PageModel
    {
        private IOrderService _orderService;

        public CreateModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Discount Discount { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(string startDate, string endDate)
        {
            if (!string.IsNullOrEmpty(startDate))
            {
                // feed start date
                string[] startDateArray = startDate.Split("/");
                Discount.StartDate = new DateTime(
                    int.Parse(startDateArray[0]),
                    int.Parse(startDateArray[1]),
                    int.Parse(startDateArray[2]),
                    new PersianCalendar()
                );
            }

            if (!string.IsNullOrEmpty(endDate))
            {
                // feed end date
                string[] endDateArray = endDate.Split("/");
                Discount.EndDate = new DateTime(
                    int.Parse(endDateArray[0]),
                    int.Parse(endDateArray[1]),
                    int.Parse(endDateArray[2]),
                    new PersianCalendar()
                );
            }

            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _orderService.AddDiscountAsync(Discount))
                {
                    // success
                    TempData["Success"] = "کد تخفیف با موفقیت افزوده شد.";
                    return RedirectToPage("Index");
                }
                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات افزودن کد تخفیف توسط ادمین با مشکل روبرو شد.";
                return Page();
            }

            if (await _orderService.IsDiscountCodeExistAsync(Discount.DiscountCode))
            {
                // code is repititive
                TempData["WrongInputs"] = "کد تخفیف شما تکراری است.";
                return Page();
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }

        public async Task<IActionResult> OnGetCheckDiscountCode(string code)
        {
            bool isDiscountCodeExist = await _orderService.IsDiscountCodeExistAsync(code);
            return Content(isDiscountCodeExist.ToString());
        }

    }
}