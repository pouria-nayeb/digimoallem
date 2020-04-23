using DigiMoallem.BLL.DTOs.Transactions;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class TransactionController : Controller
    {
        private readonly IUserService _userService;

        public TransactionController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// User transactions center
        /// </summary>
        [Route("UserPanel/Transactions")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Charge user account
        /// </summary>
        /// <param name="chargeAccount"></param>
        [Route("UserPanel/Transactions")]
        [HttpPost]
        public async Task<IActionResult> Index(ChargeAccountViewModel chargeAccount)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                var transactionId = await _userService.ChargeUserAccountAsync(User.Identity.Name, 
                    chargeAccount.Amount, 
                    "شارژ حساب");

                if (transactionId != -1)
                {
                    // success

                    #region Online Payment

                    // feed the value to payment system
                    var payment = new Zarinpal.Payment("80b5d33a-2802-11ea-b693-000c295eb8fc", chargeAccount.Amount);

                    var response = await payment.PaymentRequest("شارژ حساب کاربری", "https://digimoallem.ir/OnlinePayment/" + transactionId);

                    switch (response.Status)
                    {
                        case 100:
                            // online payment success
                            return Redirect("https://www.zarinpal.com/pg/StartPay/" + response.Authority);
                        default:
                            // online payment failure
                            ViewData["OnlinePaymentFailure"] = "پرداخت با اشکال مواجه شد.";
                            return View(chargeAccount);
                    }

                    #endregion
                }
                else
                {
                    // db failure
                    ViewData["DbFailure"] = "بروز خطا در پایگاه داده، لطفاً مراتب را به مدیریت سامانه گزارش دهید.";
                    return View(chargeAccount);
                }
            }

            // user inputs is not valid
            ModelState["Amount"].Errors.Clear();
            ModelState.AddModelError("Amount", "مبلغ ورودی نامعتبر می باشد.");
            return View(chargeAccount);
        }
    }
}