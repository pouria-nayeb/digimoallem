using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class EditChargeModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public EditChargeModel(IUserService userService,
            IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        [BindProperty]
        public Exchange Exchange { get; set; }

        public SelectList UsersSelectList { get; set; }

        public SelectList TransactionTypeSelectList { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await SeedUsersSelectListAsync();

            Exchange = await _orderService.GetTransactionByIdAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Exchange.TransactionDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                if (await _orderService.UpdateTransactionAsync(Exchange) != null)
                {
                    TempData["Success"] = "شارژ حساب با موفقیت ویرایش شد.";

                    return RedirectToPage("Transactions");
                }
                else
                {
                    ViewData["Message"] = "بروز خطا در پایگاه داده، موارد را به توسعه دهنده گزارش دهید.";
                    await SeedUsersSelectListAsync();

                    return Page();
                }
            }

            ViewData["Message"] = "ورودی نامعتبر.";
            await SeedUsersSelectListAsync();

            return Page();
        }

        private async Task SeedUsersSelectListAsync()
        {
            UsersSelectList = new SelectList(await _userService.GetUserSelectListAsync(), "Value", "Text");
            TransactionTypeSelectList = new SelectList(_orderService.TransactionTypeSelectList(), "Value", "Text");
        }
    }
}