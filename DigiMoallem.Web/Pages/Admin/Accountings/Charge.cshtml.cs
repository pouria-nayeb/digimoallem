﻿using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class ChargeModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        public ChargeModel(IUserService userService,
            IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
        }

        [BindProperty]
        public Exchange Exchange { get; set; }

        public SelectList UsersSelectList { get; set; }

        public SelectList TransactionTypeSelectList { get; set; }

        public async Task OnGetAsync()
        {
            await SeedUsersSelectListAsync();
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            Exchange.TransactionDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                if (await _userService.AddTransactionAsync(Exchange) != -1)
                {
                    TempData["Success"] = "شارژ حساب با موفقیت انجام شد.";

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