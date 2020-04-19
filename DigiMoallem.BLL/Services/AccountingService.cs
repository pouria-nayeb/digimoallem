using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Accounting;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class AccountingService : IAccountingService
    {
        private ApplicationDbContext _db;
        private readonly ICourseService _courseService;

        public AccountingService(ApplicationDbContext db, ICourseService courseService)
        {
            _db = db;
            _courseService = courseService;
        }

        /// <summary>
        /// Add payment
        /// </summary>
        /// <param name="payemt"></param>
        /// <returns></returns>
        #region AddPayment
        public bool AddPayment(Payment payemt)
        {
            try
            {
                // db success
                _db.Payments.Add(payemt);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddPaymentAsync(Payment payemt)
        {
            try
            {
                // db success
                await _db.Payments.AddAsync(payemt);
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
        /// Get payment by id
        /// </summary>
        /// <param name="paymentId"></param>
        /// <returns></returns>
        #region GetPaymentById
        public Payment GetPaymentById(int paymentId)
        {
            return _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
                .SingleOrDefault(p => p.PaymentId == paymentId);
        }

        public async Task<Payment> GetPaymentByIdAsync(int paymentId)
        {
            return await _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
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
            int skip = (pageId - 1) * recordsPerPage;
            int pageCount = _db.Payments.Count() / recordsPerPage;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return new AccountingViewModel
            {
                CurrentPage = pageId,
                PageCount = pageCount,
                Payments = _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
                .OrderByDescending(p => p.PaymentId)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToList()
            };
        }

        public async Task<AccountingViewModel> GetPaymentsAsync(int pageId = 1, int recordsPerPage = 20)
        {
            int skip = (pageId - 1) * recordsPerPage;
            int pageCount = ((await _db.Payments.CountAsync()) / recordsPerPage);

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return new AccountingViewModel
            {
                CurrentPage = pageId,
                PageCount = pageCount,
                Payments = _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
                .OrderByDescending(p => p.PaymentId)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToList()
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

        #region TeacherIncomePerCourse
        public int TeacherIncomePerCourse(int teacherId, int courseId)
        {
            return _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
                .Where(p => p.TeacherId == teacherId && p.CourseId == courseId)
                .Select(p => p.Amount)
                .Sum();
        }

        public async Task<int> TeacherIncomePerCourseAsync(int teacherId, int courseId)
        {
            return await _db.Payments
                .Include(p => p.User)
                .Include(p => p.Course)
                .Where(p => p.TeacherId == teacherId && p.CourseId == courseId)
                .Select(p => p.Amount)
                .SumAsync();
        }
        #endregion

        #region TeacherRemainPayment
        public int TeacherRemainPayment(int teacherId, int courseId)
        {
            var course = _courseService.GetCourseById(courseId);
            var teacherPayment = TeacherIncomePerCourse(teacherId, courseId);

            if (course.TeacherIncome > 0)
            {
                return (int)(course.TeacherIncome - teacherPayment);
            }

            return 0;
        }

        public async Task<int> TeacherRemainPaymentAsync(int teacherId, int courseId)
        {
            var course = await _courseService.GetCourseByIdAsync(courseId);
            var teacherPayment = await TeacherIncomePerCourseAsync(teacherId, courseId);

            if (course.TeacherIncome > 0)
            {
                return (int)(course.TeacherIncome - teacherPayment);
            }

            return 0;
        }
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
        #endregion
    }
}
