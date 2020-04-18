using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DigiMoallem.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 400:
                    // bad request
                    ViewBag.ErrorMessage = "متاسفانه، در خواست ارسالی شما به سرور صحیح نمی باشد..";
                    break;
                case 401:
                    // not authorized
                    ViewBag.ErrorMessage = "متاسفانه، امکان دسترسی شما به این ناحیه ممکن نمی باشد.";
                    break;
                case 404:
                    // not found
                    ViewBag.ErrorMessage = "متاسفانه، صفحه مورد نظر شما یافت نشد.";
                    break;
                case 500:
                    // internal server error
                    ViewBag.ErrorMessage = "بروز خطا در سرور.";
                    break;
                default:
                    // any other error
                    ViewBag.ErrorMessage = "بروز خطا در سامانه، لطفاً تا زمان رفع مشکل شکیبا باشید.";
                    break;
            }

            ViewBag.Path = statusCodeResult.OriginalPath;
            ViewBag.QueryString = statusCodeResult.OriginalQueryString;
            return View("Error");
        }
    }
}