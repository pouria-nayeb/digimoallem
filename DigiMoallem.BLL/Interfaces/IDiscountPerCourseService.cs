using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.DAL.Entities.Orders;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IDiscountPerCourseService
    {
        DiscountType UseDiscount(int orderId, string code);

        bool AddDiscount(DiscountPerCourse discount);

        DiscountPerCourseViewModel GetDiscounts(int pageNumber = 1, int pageSize = 32);

        DiscountPerCourse GetDiscountById(int discountId);

        bool UpdateDiscount(DiscountPerCourse discount);

        bool IsDiscountCodeExist(string discountCode);

        bool IsUserBuyCourse(string userName, int courseId);

        int DiscountPerCoursesCount();
    }
}
