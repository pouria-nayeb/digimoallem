using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Discounts
{
    public class EditModel : PageModel
    {
        private IOrderService _orderService;

        public EditModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [BindProperty]
        public Discount Discount { get; set; }

        public async Task OnGetAsync(int id)
        {
            Discount = await _orderService.GetDiscountByIdAsync(id);
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

                if (await _orderService.UpdateDiscountAsync(Discount))
                {
                    // success
                    TempData["Success"] = "کد تخفیف با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات ویرایش کد تخفیف توسط ادمین با مشکل روبرو شد."; return LocalRedirect("/Admin/Discount/Edit/");
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return LocalRedirect("/Admin/Discount/Edit/");
        }
    }
}