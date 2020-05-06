using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.DiscountPerCourses
{
    [PermissionChecker(19)]
    public class IndexModel : PageModel
    {
        private readonly IDiscountPerCourseService _discountPerCourseService;

        public IndexModel(IDiscountPerCourseService discountPerCourseService)
        {
            _discountPerCourseService = discountPerCourseService;
        }

        public DiscountPerCourseViewModel DiscountViewModel { get; set; }

        public int DiscountsCount { get; set; }

        public void OnGet(int pageNumber = 1, int pageSize = 32)
        {
            DiscountViewModel = _discountPerCourseService.GetDiscounts(pageNumber, pageSize);
            DiscountsCount = _discountPerCourseService.DiscountPerCoursesCount();
        }
    }
}