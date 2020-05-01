using DigiMoallem.BLL.DTOs.Admin.Discounts;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.DTOs.Transactions;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Transactions;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class OrderService : IOrderService
    {
        private ApplicationDbContext _db;
        private IUserService _userService;
        private ICourseService _courseService;

        public OrderService(ApplicationDbContext db, IUserService userService, ICourseService courseService)
        {
            _db = db;
            _userService = userService;
            _courseService = courseService;
        }

        /// <summary>
        /// Get order by id
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        #region GetOrderById
        public Order GetOrderById(int orderId)
        {
            return _db.Orders.Include(o => o.User)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Course)
                .SingleOrDefault(o => o.OrderId == orderId);
        }

        public async Task<Order> GetOrderByIdAsync(int orderId)
        {
            return await _db.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Course)
                .SingleOrDefaultAsync(o => o.OrderId == orderId);
        }
        #endregion

        /// <summary>
        /// Add order to user's shopping cart
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region AddOrder
        public int AddOrder(string userName, int courseId)
        {
            try
            {
                // db success
                int userId = _userService.GetUserIdByUserName(userName);

                Order order = _db.Orders
                    .FirstOrDefault(o => o.UserId == userId && !o.IsFinally);

                var course = _courseService.GetCourseById(courseId);

                if (order == null)
                {
                    // new order
                    order = new Order()
                    {
                        UserId = userId,
                        IsFinally = false,
                        CreateDate = DateTime.Now,
                        TotalPrice = course.Price,
                        OrderDetails = new List<OrderDetail>() {
                        new OrderDetail() {
                            CourseId = courseId,
                            Count = 1,
                            Price = course.Price
                        }
                      }
                    };

                    _db.Orders.Add(order);
                    Save();
                }
                else
                {
                    // order exist
                    OrderDetail orderDetail = _db.OrderDetails
                        .FirstOrDefault(od => od.OrderId == order.OrderId && od.CourseId == courseId);

                    if (orderDetail != null)
                    {
                        orderDetail.Count = 1;
                    }
                    else
                    {
                        orderDetail = new OrderDetail()
                        {
                            OrderId = order.OrderId,
                            Count = 1,
                            CourseId = courseId,
                            Price = course.Price
                        };
                        _db.OrderDetails.Add(orderDetail);
                        Save();
                        UpdateOrderPrice(order.OrderId);
                    }
                }

                return order.OrderId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }

        public async Task<int> AddOrderAsync(string userName, int courseId)
        {
            try
            {
                // db success
                int userId = await _userService.GetUserIdByUserNameAsync(userName);

                Order order = await _db.Orders
                    .FirstOrDefaultAsync(o => o.UserId == userId && !o.IsFinally);

                var course = await _courseService.GetCourseByIdAsync(courseId);

                if (order == null)
                {
                    // new order
                    order = new Order()
                    {
                        UserId = userId,
                        IsFinally = false,
                        CreateDate = DateTime.Now,
                        TotalPrice = course.Price,
                        OrderDetails = new List<OrderDetail>() {
                        new OrderDetail() {
                            CourseId = courseId,
                            Count = 1,
                            Price = course.Price
                        }
                      }
                    };

                    await _db.Orders.AddAsync(order);
                    await SaveAsync();
                }
                else
                {
                    // order exist
                    OrderDetail orderDetail = await _db.OrderDetails
                        .FirstOrDefaultAsync(od => od.OrderId == order.OrderId && od.CourseId == courseId);

                    if (orderDetail != null)
                    {
                        orderDetail.Count = 1;
                    }
                    else
                    {
                        orderDetail = new OrderDetail()
                        {
                            OrderId = order.OrderId,
                            Count = 1,
                            CourseId = courseId,
                            Price = course.Price
                        };
                        await _db.OrderDetails.AddAsync(orderDetail);
                        await SaveAsync();
                        await UpdateOrderPriceAsync(order.OrderId);
                    }
                }

                return order.OrderId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Update order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        #region UpdateOrder
        public bool UpdateOrder(Order order)
        {
            try
            {
                // db success
                _db.Orders.Update(order);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            try
            {
                // db success
                _db.Orders.Update(order);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Update order price for new course
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        #region UpdateOrderPrice
        public bool UpdateOrderPrice(int orderId)
        {
            try
            {
                // db success
                var order = _db.Orders.SingleOrDefault(o => o.OrderId == orderId);

                order.TotalPrice = _db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Price);

                _db.Orders.Update(order);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateOrderPriceAsync(int orderId)
        {
            try
            {
                // db success
                var order = await _db.Orders.SingleOrDefaultAsync(o => o.OrderId == orderId);

                order.TotalPrice = _db.OrderDetails.Where(od => od.OrderId == orderId).Sum(od => od.Price);

                _db.Orders.Update(order);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Get user factor
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        #region GetOrderToShowFactor
        public Order GetOrderToShowFactor(string userName, int orderId)
        {
            int userId = _userService
                .GetUserIdByUserName(userName);

            return _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Course)
                .SingleOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public async Task<Order> GetOrderToShowFactorAsync(string userName, int orderId)
        {
            int userId = await _userService
                .GetUserIdByUserNameAsync(userName);

            return await _db.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Course)
                .SingleOrDefaultAsync(o => o.UserId == userId && o.OrderId == orderId);
        }
        #endregion

        #region RemoveOrder
        public void RemoveOrder(int orderId)
        {
            var order = GetOrderById(orderId);

            order.IsFinally = false;

            UpdateOrder(order);
            Save();
        }
        #endregion

        /// <summary>
        /// Guide user to payment system (?)
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="orderId"></param>
        /// <returns></returns>
        #region OrderPayment
        public bool OrderPayment(string userName, int orderId)
        {
            try
            {
                // db success
                int userId = _userService.GetUserIdByUserName(userName);
                var order = GetOrderToShowFactor(userName, orderId);

                if (order == null || order.IsFinally)
                {
                    return false;
                }

                if (_userService.GetUserBalance(userName) >= order.TotalPrice)
                {
                    order.IsFinally = true;
                    _userService.AddTransaction(new Exchange()
                    {
                        Amount = order.TotalPrice,
                        TransactionDate = DateTime.Now,
                        IsPay = true,
                        Description = "فاکتور شماره #" + order.OrderId,
                        UserId = userId,
                        TransactionTypeId = 2
                    });
                    _db.Orders.Update(order);

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        _db.UserCourses.Add(new UserCourse()
                        {
                            CourseId = orderDetail.CourseId,
                            UserId = userId
                        });

                    }

                    Save();

                    return true;
                }

                return false;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> OrderPaymentAsync(string userName, int orderId)
        {
            try
            {
                // db success
                int userId = await _userService.GetUserIdByUserNameAsync(userName);
                var order = await GetOrderToShowFactorAsync(userName, orderId);

                if (order == null || order.IsFinally)
                {
                    return false;
                }

                if (await _userService.GetUserBalanceAsync(userName) >= order.TotalPrice)
                {
                    order.IsFinally = true;
                    await _userService.AddTransactionAsync(new Exchange()
                    {
                        Amount = order.TotalPrice,
                        TransactionDate = DateTime.Now,
                        IsPay = true,
                        Description = "فاکتور شماره #" + order.OrderId,
                        UserId = userId,
                        TransactionTypeId = 2
                    });
                    _db.Orders.Update(order);

                    foreach (var orderDetail in order.OrderDetails)
                    {
                        await _db.UserCourses.AddAsync(new UserCourse()
                        {
                            CourseId = orderDetail.CourseId,
                            UserId = userId
                        });

                    }

                    await SaveAsync();

                    return true;
                }

                return false;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Remove order from shopping cart
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region RemoveOrder
        public int RemoveOrder(string userName, int courseId)
        {
            try
            {
                // db success
                int userId = _userService.GetUserIdByUserName(userName);

                Order order = _db.Orders.FirstOrDefault(o => o.UserId == userId && !o.IsFinally);

                OrderDetail orderDetail = _db.OrderDetails.FirstOrDefault(o => o.OrderId == order.OrderId && o.CourseId == courseId);

                if (orderDetail.Count == 1)
                {
                    _db.OrderDetails.Remove(orderDetail);
                }

                Save();

                UpdateOrderPrice(order.OrderId);

                return order.OrderId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }

        public async Task<int> RemoveOrderAsync(string userName, int courseId)
        {
            try
            {
                // db success
                int userId = await _userService.GetUserIdByUserNameAsync(userName);

                Order order = await _db.Orders.FirstOrDefaultAsync(o => o.UserId == userId && !o.IsFinally);

                OrderDetail orderDetail = await _db.OrderDetails.FirstOrDefaultAsync(o => o.OrderId == order.OrderId && o.CourseId == courseId);

                if (orderDetail.Count == 1)
                {
                    _db.OrderDetails.Remove(orderDetail);
                }

                await SaveAsync();

                await UpdateOrderPriceAsync(order.OrderId);

                return order.OrderId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        #region GetTransactionById
        public Exchange GetTransactionById(int transactionId) => _db.Exchanges
            .SingleOrDefault(t => t.ExchangeId == transactionId);

        public async Task<Exchange> GetTransactionByIdAsync(int transactionId) => await _db.Exchanges
            .SingleOrDefaultAsync(t => t.ExchangeId == transactionId);
        #endregion

        /// <summary>
        /// List of user orders
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        #region GetUserOrders
        public List<Order> GetUserOrders(string userName)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _db.Orders
                .OrderByDescending(o => o.OrderId)
                .Where(o => o.UserId == userId)
                .AsNoTracking()
                .ToList();
        }

        public async Task<List<Order>> GetUserOrdersAsync(string userName)
        {
            int userId = await _userService.GetUserIdByUserNameAsync(userName);

            return await _db.Orders
                .OrderByDescending(o => o.OrderId)
                .Where(o => o.UserId == userId)
                .AsNoTracking()
                .ToListAsync();
        }
        #endregion

        #region GetAllOrders
        public OrderPagingViewModel GetAllOrders(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Order> orders = _db.Orders;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = orders.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new OrderPagingViewModel
            {
                Orders = orders.Skip(skip).Take(take)
                .OrderByDescending(o => o.OrderId)
                .Include(o => o.User)
                .AsNoTracking()
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public async Task<OrderPagingViewModel> GetAllOrdersAsync(int pageNumber, int pageSize)
        {
            IQueryable<Order> orders = _db.Orders;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = await orders.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new OrderPagingViewModel
            {
                Orders = await orders.Skip(skip).Take(take)
                .OrderByDescending(o => o.OrderId)
                .Include(o => o.User)
                .AsNoTracking()
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region SearchOrdersAsync
        public async Task<OrderPagingViewModel> SearchOrdersAsync(string email, int pageNumber, int pageSize)
        {
            IQueryable<Order> orders = _db.Orders;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = await orders.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new OrderPagingViewModel
            {
                Orders = await orders
                .Include(o => o.User)
                .Where(o => o.User.Email.TextTransform().Contains(email.TextTransform()))
                .Skip(skip)
                .Take(take)
                .OrderByDescending(o => o.CreateDate)
                .Include(o => o.User)
                .AsNoTracking()
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region GetAllUserCourses
        public UserCoursePagingViewModel GetAllUserCourses(int pageNumber, int pageSize)
        {
            IQueryable<UserCourse> userCourses = _db.UserCourses;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = userCourses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new UserCoursePagingViewModel
            {
                UserCourses = userCourses.Skip(skip).Take(take)
                .OrderByDescending(o => o.UserCourseId)
                .Include(o => o.User)
                .Include(o => o.Course)
                .AsNoTracking()
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public async Task<UserCoursePagingViewModel> GetAllUserCoursesAsync(int pageNumber, int pageSize)
        {
            IQueryable<UserCourse> userCourses = _db.UserCourses;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = await userCourses.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new UserCoursePagingViewModel
            {
                UserCourses = await userCourses.Skip(skip).Take(take)
                .OrderByDescending(o => o.UserCourseId)
                .Include(o => o.User)
                .Include(o => o.Course)
                .AsNoTracking()
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region SearchUserCoursesAsync
        public async Task<UserCoursePagingViewModel> SearchUserCoursesAsync(string email, int pageNumber, int pageSize)
        {
            IQueryable<UserCourse> userCourses = _db.UserCourses;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int ordersCount = await userCourses.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(ordersCount, take));

            return new UserCoursePagingViewModel
            {
                UserCourses = await userCourses
                .Include(o => o.User)
                .Include(o => o.Course)
                .Where(uc => uc.User.Email.TextTransform().Contains(email.TextTransform()))
                .Skip(skip)
                .Take(take)
                .OrderByDescending(o => o.UserId)
                .AsNoTracking()
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        public List<SelectListItem> TransactionTypeSelectList() => _db.TransactionTypes.Select(tt => new SelectListItem
        {
            Text = tt.TypeTitle,
            Value = tt.TransactionTypeId.ToString()
        }).ToList();

        #region AddUserCourse
        public UserCourse AddUserCourse(UserCourse userCourse)
        {
            try
            {
                _db.UserCourses.Add(userCourse);
                Save();

                return userCourse;
            }
            catch
            {
                return null;
            }
        }
        public async Task<UserCourse> AddUserCourseAsync(UserCourse userCourse)
        {
            try
            {
                await _db.UserCourses.AddAsync(userCourse);
                await SaveAsync();

                return userCourse;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region RemoveUserCourse
        public void RemoveUserCourse(int userCourseId)
        {
            var userCourse = GetUserCourseById(userCourseId);

            _db.UserCourses.Remove(userCourse);
            Save();
        }
        #endregion

        #region GetAllTransactions
        public TransactionPagingViewModel GetAllTransactions(int pageNumber = 1, int pageSize = 64)
        {
            IQueryable<Exchange> result = _db.Exchanges;

            // pagination logic
            int take = pageSize;
            int skip = (pageNumber - 1) * take;

            int discountsCount = result.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(discountsCount, take));

            return new TransactionPagingViewModel
            {
                PageNumber = pageNumber,
                PageCount = pagesCount,
                Exchanges = result
                .OrderByDescending(d => d.ExchangeId)
                .Skip(skip)
                .Take(take)
                .Include(e => e.User)
                .AsNoTracking()
                .ToList()
            };
        }

        public async Task<TransactionPagingViewModel> GetAllTransactionsAsync(int pageNumber = 1, int pageSize = 64)
        {
            IQueryable<Exchange> result = _db.Exchanges;

            // pagination logic
            int take = pageSize;
            int skip = (pageNumber - 1) * take;

            int discountsCount = await result.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(discountsCount, take));

            return new TransactionPagingViewModel
            {
                PageNumber = pageNumber,
                PageCount = pagesCount,
                Exchanges = await result
                .OrderByDescending(d => d.ExchangeId)
                .Skip(skip)
                .Take(take)
                .Include(e => e.User)
                .AsNoTracking()
                .ToListAsync()
            };
        }
        #endregion

        /// <summary>
        /// User used discount
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        #region UseDicount
        public DiscountType UseDiscount(int orderId, string code)
        {
            var discount = _db.Discounts.SingleOrDefault(d => d.DiscountCode == code);

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

            var order = GetOrderById(orderId);

            if (_db.UserDiscountCodes.Any(udc => udc.UserId == order.UserId && udc.DiscountId == discount.DiscountId))
            {
                // token is used by user
                return DiscountType.UsedByUser;
            }

            var offAmount = (order.TotalPrice * discount.DiscountPercent) / 100;

            order.TotalPrice = order.TotalPrice - offAmount;

            UpdateOrder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _db.Discounts.Update(discount);

            _db.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });

            Save();

            return DiscountType.Success;
        }

        public async Task<DiscountType> UseDiscountAsync(int orderId, string code)
        {
            var discount = _db.Discounts.SingleOrDefault(d => d.DiscountCode == code);

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

            var order = GetOrderById(orderId);

            if (_db.UserDiscountCodes.Any(udc => udc.UserId == order.UserId && udc.DiscountId == discount.DiscountId))
            {
                // token is used by user
                return DiscountType.UsedByUser;
            }

            var offAmount = (order.TotalPrice * discount.DiscountPercent) / 100;

            order.TotalPrice = order.TotalPrice - offAmount;

            await UpdateOrderAsync(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _db.Discounts.Update(discount);

            _db.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });

            await _db.UserDiscountCodes.AddAsync(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });

            await SaveAsync();

            return DiscountType.Success;
        }
        #endregion

        #region UpdateTransaction
        public Exchange UpdateTransaction(Exchange exchange)
        {
            try
            {
                _db.Exchanges.Update(exchange);
                Save();

                return exchange;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Exchange> UpdateTransactionAsync(Exchange exchange)
        {
            try
            {
                _db.Exchanges.Update(exchange);
                await SaveAsync();

                return exchange;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region GetUserCourseById
        public UserCourse GetUserCourseById(int userCourseId) => _db.UserCourses
            .Include(uc => uc.User)
            .Include(uc => uc.Course)
            .SingleOrDefault(uc => uc.UserCourseId == userCourseId);

        public async Task<UserCourse> GetUserCourseByIdAsync(int userCourseId) => await _db.UserCourses
            .Include(uc => uc.User)
            .Include(uc => uc.Course)
            .SingleOrDefaultAsync(uc => uc.UserCourseId == userCourseId);
        #endregion

        #region UpdateUserCourse
        public UserCourse UpdateUserCourse(UserCourse userCourse)
        {
            try
            {
                _db.UserCourses.Update(userCourse);
                Save();

                return userCourse;
            }
            catch
            {
                return null;
            }
        }
        public async Task<UserCourse> UpdateUserCourseAsync(UserCourse userCourse)
        {
            try
            {
                _db.UserCourses.Update(userCourse);
                await SaveAsync();

                return userCourse;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        /// <summary>
        /// Add discount
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        #region AddDiscount
        public bool AddDiscount(Discount discount)
        {
            try
            {
                // db success
                _db.Discounts.Add(discount);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddDiscountAsync(Discount discount)
        {
            try
            {
                // db success
                await _db.Discounts.AddAsync(discount);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Get discounts
        /// </summary>
        /// <param name="pageId"></param>
        /// <returns></returns>
        #region GetDiscounts
        public DiscountViewModel GetDiscounts(int pageId = 1)
        {
            IQueryable<Discount> result = _db.Discounts;

            // pagination logic
            int recordsPerPage = 20;
            int skip = (pageId - 1) * recordsPerPage;

            int discountsCount = result.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(discountsCount, recordsPerPage));

            var discountVM = new DiscountViewModel
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Discounts = result
                .OrderByDescending(d => d.DiscountId)
                .Skip(skip)
                .Take(recordsPerPage)
                .AsNoTracking()
                .ToList()
            };

            return discountVM;
        }

        public async Task<DiscountViewModel> GetDiscountsAsync(int pageId = 1)
        {
            IQueryable<Discount> result = _db.Discounts;

            // pagination logic
            int recordsPerPage = 20;
            int skip = (pageId - 1) * recordsPerPage;

            int discountsCount = result.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(discountsCount, recordsPerPage));

            var discountVM = new DiscountViewModel
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Discounts = await result
                .OrderByDescending(d => d.DiscountId)
                .Skip(skip)
                .Take(recordsPerPage)
                .AsNoTracking()
                .ToListAsync()
            };

            return discountVM;
        }
        #endregion

        #region TransactionsCount
        public int TransactionsCount() => _db.Exchanges.Count();
        #endregion

        /// <summary>
        /// Get discount by id
        /// </summary>
        /// <param name="discountId"></param>
        /// <returns></returns>
        #region GetDiscount
        public Discount GetDiscountById(int discountId)
        {
            return _db.Discounts.SingleOrDefault(d => d.DiscountId == discountId);
        }

        public async Task<Discount> GetDiscountByIdAsync(int discountId)
        {
            return await _db.Discounts.SingleOrDefaultAsync(d => d.DiscountId == discountId);
        }
        #endregion

        /// <summary>
        /// Update discount
        /// </summary>
        /// <param name="discount"></param>
        /// <returns></returns>
        #region UpdateDiscount
        public bool UpdateDiscount(Discount discount)
        {
            try
            {
                // db success
                _db.Discounts.Update(discount);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateDiscountAsync(Discount discount)
        {
            try
            {
                // db success
                _db.Discounts.Update(discount);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Check if discount code existance
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        #region IsDiscountCodeExist
        public bool IsDiscountCodeExist(string discountCode)
        {
            return _db.Discounts.Any(d => d.DiscountCode == discountCode);
        }

        public async Task<bool> IsDiscountCodeExistAsync(string discountCode)
        {
            return await _db.Discounts.AnyAsync(d => d.DiscountCode == discountCode);
        }
        #endregion

        /// <summary>
        /// Check if user bought the course
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region IsUserBuyCourse
        public bool IsUserBuyCourse(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _db.UserCourses.Any(uc => uc.UserId == userId && uc.CourseId == courseId);
        }

        public async Task<bool> IsUserBuyCourseAsync(string userName, int courseId)
        {
            int userId = await _userService.GetUserIdByUserNameAsync(userName);

            return await _db.UserCourses.AnyAsync(uc => uc.UserId == userId && uc.CourseId == courseId);
        }
        #endregion

        #region OrdersCount
        public int OrdersCount() => _db.Orders.Count();
        public async Task<int> OrdersCountAsync() => await _db.Orders.CountAsync();
        #endregion

        #region DiscountsCount
        public int DiscountsCount() => _db.Discounts.Count();
        public async Task<int> DiscountsCountAsync() => await _db.Discounts.CountAsync();
        #endregion

        #region Save
        public void Save()
        {
            _db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                GC.SuppressFinalize(true);
            }

            _db = null;
        }
        #endregion
    }
}
