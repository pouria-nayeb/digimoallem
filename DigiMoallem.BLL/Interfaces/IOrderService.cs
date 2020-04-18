using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.DAL.Entities.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IOrderService
    {
        // order
        #region GetOrderById
        Order GetOrderById(int orderId);
        Task<Order> GetOrderByIdAsync(int orderId);
        #endregion

        #region AddOrder
        int AddOrder(string userName, int courseId);
        Task<int> AddOrderAsync(string userName, int courseId);
        #endregion

        #region UpdateOrder
        bool UpdateOrder(Order order);
        Task<bool> UpdateOrderAsync(Order order);
        #endregion

        #region UpdateOrderPrice
        bool UpdateOrderPrice(int orderId);
        Task<bool> UpdateOrderPriceAsync(int orderId);
        #endregion

        #region GetOrderToShowFactor
        Order GetOrderToShowFactor(string userName, int orderId);
        Task<Order> GetOrderToShowFactorAsync(string userName, int orderId);
        #endregion

        #region OrderPayment
        bool OrderPayment(string userName, int orderId);
        Task<bool> OrderPaymentAsync(string userName, int orderId);
        #endregion

        #region RemoveOrder
        int RemoveOrder(string userName, int courseId);
        Task<int> RemoveOrderAsync(string userName, int courseId);
        #endregion

        #region GetUserOrders
        List<Order> GetUserOrders(string userName);
        Task<List<Order>> GetUserOrdersAsync(string userName);
        #endregion

        // discount
        #region UseDicount
        DiscountType UseDiscount(int orderId, string code);
        Task<DiscountType> UseDiscountAsync(int orderId, string code);
        #endregion

        #region AddDiscount
        bool AddDiscount(Discount discount);
        Task<bool> AddDiscountAsync(Discount discount);
        #endregion

        #region GetDiscounts
        DiscountViewModel GetDiscounts(int pageId = 1);
        Task<DiscountViewModel> GetDiscountsAsync(int pageId = 1);
        #endregion

        #region GetDiscount
        Discount GetDiscountById(int discountId);
        Task<Discount> GetDiscountByIdAsync(int discountId);
        #endregion

        #region UpdateDiscount
        bool UpdateDiscount(Discount discount);
        Task<bool> UpdateDiscountAsync(Discount discount);
        #endregion

        #region IsDiscountCodeExist
        bool IsDiscountCodeExist(string discountCode);
        Task<bool> IsDiscountCodeExistAsync(string discountCode);
        #endregion

        #region IsUserBuyCourse
        bool IsUserBuyCourse(string userName, int courseId);
        Task<bool> IsUserBuyCourseAsync(string userName, int courseId);
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion

    }
}
