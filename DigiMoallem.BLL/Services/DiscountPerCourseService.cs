using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigiMoallem.BLL.Services
{
    public class DiscountPerCourseService : IDiscountPerCourseService
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserService _userService;
        private readonly ICourseService _courseService;
        private readonly IOrderService _orderService;

        public DiscountPerCourseService(ApplicationDbContext context,
            IUserService userService,
            ICourseService courseService,
            IOrderService orderService)
        {
            _context = context;
            _userService = userService;
            _courseService = courseService;
            _orderService = orderService;
        }

        public DiscountType UseDiscount(int orderId, string code)
        {
            var discount = _context.DiscountPerCourses.SingleOrDefault(d => d.DiscountCode == code);

            if (discount == null)
            {
                // discount not exist
                return DiscountType.NotFound;
            }

            if (discount.StartDate != null && discount.StartDate >= DateTime.Now)
            {
                // start date is wrong
                return DiscountType.Expired;
            }

            if (discount.EndDate != null && discount.EndDate <= DateTime.Now)
            {
                // end date is wrong
                return DiscountType.Expired;
            }

            if (discount.UsableCount != null && discount.UsableCount < 1)
            {
                // tokens end
                return DiscountType.Finished;
            }

            var order = _orderService.GetOrderById(orderId);

            if (_context.UserDiscountCodePerCourses.Any(udc => udc.UserId == order.UserId && udc.DiscountPerCourseId == discount.DiscountPerCourseId))
            {
                // token is used by user
                return DiscountType.UsedByUser;
            }

            if (!IsDiscountCodeExist(discount.DiscountCode))
            {
                return DiscountType.NotFound;
            }

            if (order.OrderDetails.Any(od => od.CourseId == discount.CourseId))
            {
                var course = _courseService.GetCourseById(discount.CourseId);

                var offAmount = (course.Price * discount.DiscountPercent) / 100;

                order.OrderDetails.Single(od => od.CourseId == course.CourseId).Price = (order.OrderDetails.Single(od => od.CourseId == course.CourseId).Price - offAmount);

                order.TotalPrice = order.OrderDetails.Select(od => od.Price).Sum();

                _orderService.UpdateOrder(order);
            }

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _context.DiscountPerCourses.Update(discount);

            _context.UserDiscountCodePerCourses.Add(new UserDiscountCodePerCourse()
            {
                UserId = order.UserId,
                DiscountPerCourseId = discount.DiscountPerCourseId
            });

            _context.SaveChanges();

            return DiscountType.Success;
        }

        public bool AddDiscount(DiscountPerCourse discount)
        {
            try
            {
                // db success
                _context.DiscountPerCourses.Add(discount);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public DiscountPerCourseViewModel GetDiscounts(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<DiscountPerCourse> discountPerCourses = _context.DiscountPerCourses;

            int take = pageSize;
            int skip = (pageNumber - 1) * pageSize;
            int discountPerCourse = discountPerCourses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(discountPerCourse, take));

            return new DiscountPerCourseViewModel
            {
                Discounts = discountPerCourses.
                Include(d => d.Course)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(d => d.DiscountPerCourseId)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public DiscountPerCourse GetDiscountById(int discountId) => _context.DiscountPerCourses.Find(discountId);

        public bool UpdateDiscount(DiscountPerCourse discount)
        {
            try
            {
                // db success
                _context.DiscountPerCourses.Update(discount);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public bool IsDiscountCodeExist(string discountCode) => _context.DiscountPerCourses
            .Any(d => d.DiscountCode == discountCode);

        public bool IsUserBuyCourse(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.UserCourses.Any(uc => uc.UserId == userId && uc.CourseId == courseId);
        }

        public int DiscountPerCoursesCount() => _context.DiscountPerCourses.Count();
    }
}
