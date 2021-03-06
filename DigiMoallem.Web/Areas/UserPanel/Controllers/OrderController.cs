﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DigiMoallem.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class OrderController : Controller
    {
        private ICourseService _courseService;
        private IDiscountPerCourseService _discountPerCourseService;
        private IOrderService _orderService;

        public OrderController(IOrderService orderService, 
            ICourseService courseService,
            IDiscountPerCourseService discountPerCourseService)
        {
            _orderService = orderService;
            _courseService = courseService;
            _discountPerCourseService = discountPerCourseService;
        }

        [Route("Factors")]
        public async Task<IActionResult> ShowFactors()
        {
            return View(await _orderService.GetUserOrdersAsync(User.Identity.Name));
        }

        /// <summary>
        /// user's shopping cart
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isFinally"></param>
        /// <returns></returns>
        [Route("Cart/{id}")]
        public async Task<IActionResult> Index(int id, bool isFinally = false, string type = "")
        {
            var order = await _orderService.GetOrderToShowFactorAsync(User.Identity.Name, id);

            if (order == null)
            {
                return NotFound();
            }

            ViewBag.IsFinally = isFinally;

            ViewBag.DiscountType = type;

            return View(order);
        }

        /// <summary>
        /// Order payment process
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Checkout/{id}")]
        public async Task<IActionResult> PaymentProcess(int id)
        {
            if (await _orderService.OrderPaymentAsync(User.Identity.Name, id))
            {
                // success

                return Redirect("/Cart/" + id + "?isFinally=true");
            }
            else
            {
                // failure
                return BadRequest();
            }
        }

        [Route("ApplyDiscount")]
        public async Task<IActionResult> ApplyDiscount(int orderId, string code)
        {

            if (string.IsNullOrEmpty(code))
            {
                return RedirectToAction("Index", new { id = orderId });
            }

            DiscountType type = await _orderService.UseDiscountAsync(orderId, code);

            if (type ==  DiscountType.Success || type == DiscountType.Expired || type == DiscountType.UsedByUser)
            {
                DiscountTypeDescision(type);
            } else 
            {
                DiscountType typePerCourse = _discountPerCourseService.UseDiscount(orderId, code);
                DiscountTypeDescision(typePerCourse);
            }

            return Redirect("/Cart/" + orderId + "?code=" + code.ToString());
        }

        private void DiscountTypeDescision(DiscountType type) 
        {
            switch (type)
            {
                case DiscountType.Success:
                    TempData["Success"] = "کد تخفیف با موفقیت اعمال شد.";
                    break;
                case DiscountType.Expired:
                    TempData["Failure"] = "زمان استفاده از این کد تخفیف پایان یافته است.";
                    break;
                case DiscountType.NotFound:
                    TempData["Failure"] = "کد تخفیف یافت نشد.";
                    break;
                case DiscountType.Finished:
                    TempData["Failure"] = "کد تخفیف تمام شده است.";
                    break;
                case DiscountType.UsedByUser:
                    TempData["Failure"] = "این کد تخفیف توسط شما استفاده شده است.";
                    break;
                default:
                    TempData["Failure"] = "درخواست نامعتبر.";
                    break;
            }
        }
    }
}