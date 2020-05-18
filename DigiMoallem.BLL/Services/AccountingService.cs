using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Orders;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class AccountingService : IAccountingService
    {
        private ApplicationDbContext _db;
        private readonly ICourseService _courseService;
        private readonly IUserService _userService;
        private readonly ILogger<AccountingService> _logger;

        public AccountingService(ApplicationDbContext db, ICourseService courseService, IUserService userService, ILogger<AccountingService> logger)
        {
            _db = db;
            _courseService = courseService;
            _userService = userService;
            _logger = logger;
        }

        /// <summary>
        /// Add payment
        /// </summary>
        /// <param name="payemt"></param>
        /// <returns></returns>
        #region AddPayment
        public bool AddPayment(Payment payment)
        {
            try
            {
                // db success
                _db.Payments.Add(payment);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddPaymentAsync(Payment payment)
        {
            try
            {
                // db success
                await _db.Payments.AddAsync(payment);
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

        #region GetTeacherCourse
        public int TeacherShare(int price, int percent) 
        {
            return ((price * percent) / 100);
        }
        #endregion

        #region InstitudeShare
        public int InstitudeShare(int price, int percent)
        {
            return price - ((price * percent) / 100);
        }
        #endregion

        #region GetTotalIncome
        public int GetTotalIncome(int teacherId, int courseId) 
        {
            return _db.OrderDetails
                    .Include(od => od.Course)
                    .Include(od => od.Order)
                    .Where(od => od.Course.TeacherId == teacherId && od.CourseId == courseId && od.Order.IsFinally == true)
                    .Select(od => od.Price).Sum();
        }
        #endregion

        #region GetTeacherTotalIncome
        public int GetTeacherTotalIncome(int teacherId, int courseId)
        {

            var teacherCourseOrderDetailsPrices = _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .Where(od => od.Course.TeacherId == teacherId && od.CourseId == courseId && od.Order.IsFinally == true)
                .Select(od => od.Price);

            return teacherCourseOrderDetailsPrices.Sum();
        }
        #endregion

        #region GetTeacherIncome
        public int GetTeacherIncome(int teacherId) 
        {
            return _db.OrderDetails
                    .Include(od => od.Course)
                    .Include(od => od.Order)
                    .Where(od => od.Course.TeacherId == teacherId && od.Order.IsFinally == true).Sum(od => (od.Price * od.TeacherPercent.Value) / 100);
        }
        #endregion

        //#region JoinOrderDetailsAndPayments
        //public IQueryable<OrderDetail> JoinOrderDetailsAndPayments() 
        //{
        //return (from orderDetail in _db.OrderDetails.Include(od => od.Course)
        //        join payment in _db.Payments on orderDetail.Course.TeacherId equals payment.TeacherId
        //        select orderDetail);
        //}
        //#endregion

        #region GetTeacherTotalIncome
        //public int GetInstitudeTotalIncome(int teacherId, int courseId)
        //{
        //    return GetTotalIncome(teacherId, courseId) - GetTeacherTotalIncome(teacherId, courseId);
        //}
        #endregion

        /// <summary>
        /// Get payment by id
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        #region GetPaymentById
        public Payment GetPaymentById(int paymentId)
        {
            return _db.Payments
                .Include(p => p.User)
                .SingleOrDefault(p => p.PaymentId == paymentId);
        }

        public async Task<Payment> GetPaymentByIdAsync(int paymentId)
        {
            return await _db.Payments
                .Include(p => p.User)
                .SingleOrDefaultAsync(p => p.PaymentId == paymentId);
        }
        #endregion

        /// <summary>
        /// Get all payments
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="recordsPerPage"></param>
        /// <returns></returns>
        #region GetPayments
        public AccountingViewModel GetPayments(int pageId = 1, int recordsPerPage = 20)
        {
            IQueryable<Payment> payments = _db.Payments;

            int take = recordsPerPage;
            int skip = (pageId - 1) * recordsPerPage;
            int paymensCount = payments.Count();

            int pageCount = (int)Math.Ceiling(decimal.Divide(paymensCount, take));

            return new AccountingViewModel
            {
                PageNumber = pageId,
                PageCount = pageCount,
                Payments = _db.Payments
                .Skip(skip)
                .Take(recordsPerPage)
                .Include(p => p.User)
                .OrderByDescending(p => p.PaymentId)
                .AsNoTracking()
                .ToList()
            };
        }

        public async Task<AccountingViewModel> GetPaymentsAsync(int pageId = 1, int recordsPerPage = 20)
        {
            IQueryable<Payment> payments = _db.Payments;

            int take = recordsPerPage;
            int skip = (pageId - 1) * recordsPerPage;
            int paymensCount = payments.Count();

            int pageCount = (int)Math.Ceiling(decimal.Divide(paymensCount, take));

            return new AccountingViewModel
            {
                PageNumber = pageId,
                PageCount = pageCount,
                Payments = await _db.Payments
                                .Skip(skip)
                .Take(recordsPerPage)
                .Include(p => p.User)
                .OrderByDescending(p => p.PaymentId)
                .AsNoTracking()
                .ToListAsync()
            };
        }
        #endregion

        #region GetTeacherPaymentsByUsername
        public TeacherPaymentViewModel GetTeacherPaymentByUserName(int userId, int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Payment> payments = _db.Payments;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int paymentsCount = payments.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(paymentsCount, take));

            return new TeacherPaymentViewModel
            {
                Payments = payments
                .Where(p => p.TeacherId == userId)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(p => p.PaymentId)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public async Task<TeacherPaymentViewModel> GetTeacherPaymentByUserNameAsync(int userId, int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Payment> payments = _db.Payments;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int paymentsCount = await payments.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(paymentsCount, take));

            return new TeacherPaymentViewModel
            {
                Payments = await payments
                .Where(p => p.TeacherId == userId)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(p => p.PaymentId)
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        /// <summary>
        /// update payment
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        #region UpdatePayment
        public bool UpdatePayment(Payment payment)
        {
            try
            {
                // db success
                _db.Payments.Update(payment);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdatePaymentAsync(Payment payment)
        {
            try
            {
                // db success
                _db.Payments.Update(payment);
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
        /// remove payment
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        #region RemovePayment
        public bool RemovePayment(int paymentId)
        {
            try
            {
                // db success
                Payment payment = GetPaymentById(paymentId);
                _db.Payments.Remove(payment);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> RemovePaymentAsync(int paymentId)
        {
            try
            {
                // db success
                Payment payment = await GetPaymentByIdAsync(paymentId);
                _db.Payments.Remove(payment);
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
        /// total number of payments
        /// </summary>
        /// <returns></returns>
        #region PaymentsCount
        public int PaymentsCount()
        {
            return _db.Payments.Count();
        }

        public async Task<int> PaymentCountsAsync()
        {
            return await _db.Payments.CountAsync();
        }
        #endregion

        // purification
        #region GetPurifications
        public PurificationPagingViewModel GetPurifications(int pageNumber = 1, int pageSize = 32) 
        {
            IQueryable<Purification> purifications = _db.Purifications;

            int take = pageSize;
            int skip = (pageNumber - 1) * pageSize;
            int purificationsCount = purifications.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(purificationsCount, take));

            return new PurificationPagingViewModel
            {
                Purifications = purifications
                .Skip(skip)
                .Take(take)
                .Include(p => p.User)
                .Include(p => p.Course)
                .OrderByDescending(p => p.PurificationId)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region GetTeacherPayment
        public int GetTeacherPayment(int teacherId)
        {
            return _db.Payments.Where(p => p.TeacherId == teacherId).Sum(p => p.Amount);
        }
        #endregion

        #region GetPurificationById
        public Purification GetPurificationById(int purificationId) => _db.Purifications
            .Include(p => p.User)
            .Include(p => p.Course)
            .SingleOrDefault(p => p.PurificationId == purificationId);
        #endregion

        #region AddPurification
        public Purification AddPurification(Purification purification)
        {
            try
            {
                _db.Purifications.Add(purification);
                Save();

                return purification;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(AccountingService)}\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }
        #endregion

        #region UpdatePurification
        public Purification UpdatePurification(Purification purification)
        {
            try
            {
                _db.Purifications.Update(purification);
                Save();

                return purification;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(AccountingService)}\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }
        #endregion

        #region RemovePurification
        public Purification RemovePurification(int purificationId)
        {
            try
            {
                var purification = GetPurificationById(purificationId);

                _db.Purifications.Remove(purification);
                Save();

                return purification;
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(AccountingService)}\n{ex.StackTrace}\n{ex.Message}");

                return null;
            }
        }
        #endregion

        #region SearchPurification
        public List<Purification> SearchPurification(string query) 
        {
            if (string.IsNullOrEmpty(query))
            {
                return _db.Purifications
                    .Include(p => p.User)
                    .Include(p => p.Course)
                    .Where(p => p.User.Email.TextTransform().Contains(query.TextTransform()) || p.Course.Title.TextTransform().Contains(query.TextTransform()))
                    .ToList();
            }

            return null;
        }
        #endregion

        #region PurificationsCount
        public int PurificationsCount() => _db.Purifications.Count();
        #endregion

        #region UncheckedPurificationsCount
        public int UncheckedPurificationsCount() => _db.Purifications.Where(p => p.IsChecked == false).Count();
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
