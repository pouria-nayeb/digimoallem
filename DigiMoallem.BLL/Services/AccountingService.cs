using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Accounting;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class AccountingService : IAccountingService
    {
        private ApplicationDbContext _db;
        private readonly ICourseService _courseService;
        private readonly IUserService _userService;

        public AccountingService(ApplicationDbContext db, ICourseService courseService, IUserService userService)
        {
            _db = db;
            _courseService = courseService;
            _userService = userService;
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

                var course = _courseService.GetCourseById(payment.CourseId);

                CourseSharesCalculator(payment.TeacherId, payment.CourseId, course.TeacherPercent.Value);

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

                var course = _courseService.GetCourseById(payment.CourseId);

                CourseSharesCalculator(payment.TeacherId, payment.CourseId, course.TeacherPercent.Value);

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        #region AddTeacherPercent
        public bool AddTeacherPercent(TeacherPercentViewModel teacherPercentVM)
        {
            try
            {
                // db success

                var course = _courseService.GetCourseById(teacherPercentVM.CourseId);

                course.TeacherPercent = teacherPercentVM.Percent;

                _db.Courses.Update(course);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddTeacherPercentAsync(TeacherPercentViewModel teacherPercentVM)
        {
            try
            {
                // db success

                var course = await _courseService.GetCourseByIdAsync(teacherPercentVM.CourseId);

                course.TeacherPercent = teacherPercentVM.Percent;

                _db.Courses.Update(course);
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
                .Include(p => p.Course)
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
                .Include(p => p.Course)
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

        #region TeacherTotalPayments
        public int TeacherTotalPayments(int teacherId) => _db.Payments
            .Where(p => p.TeacherId == teacherId)
            .Select(p => p.Amount).Sum();

        public async Task<int> TeacherTotalPaymentsAsync(int teacherId) => await _db.Payments
            .Where(p => p.TeacherId == teacherId)
            .Select(p => p.Amount).SumAsync();
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
        public int TeacherIncomePerCourse(int teacherId)
        {
            return _db.Payments
                .Include(p => p.User)
                .Where(p => p.TeacherId == teacherId)
                .Select(p => p.Amount)
                .Sum();
        }

        public async Task<int> TeacherIncomePerCourseAsync(int teacherId)
        {
            return await _db.Payments
                .Include(p => p.User)
                .Where(p => p.TeacherId == teacherId)
                .Select(p => p.Amount)
                .SumAsync();
        }
        #endregion

        #region GetTeacherCurrentShare
        public TeacherShareViewModel GetTeacherCurrentShare(int userId, int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Course> courses = _db.Courses;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int paymentsCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(paymentsCount, take));

            return new TeacherShareViewModel
            {
                Courses = courses
                .Where(p => p.TeacherId == userId)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(p => p.CourseId)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }

        public async Task<TeacherShareViewModel> GetTeacherCurrentShareAsync(int userId, int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Course> courses = _db.Courses;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int paymentsCount = await courses.CountAsync();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(paymentsCount, take));

            return new TeacherShareViewModel
            {
                Courses = await courses
                .Where(p => p.TeacherId == userId)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(p => p.CourseId)
                .ToListAsync(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
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

        #region CourseSharesCalculator
        public void CourseSharesCalculator(int teacherId, int courseId, int teacherPercent)
        {
            var course = _courseService.GetCourseById(courseId);

            if (course.TotalIncome > 0)
            {
                var totalIncomeForCourse = TotalIncomeForCourse(teacherId, courseId);

                // teacher did not pay yet.
                if (TeacherTotalPayments(teacherId) == 0)
                {
                    // teacher's share from the course
                    var teacherShareForCourse = (totalIncomeForCourse * teacherPercent) / 100;
                    // institude's share from the course
                    var instutudeShareForCourse = (totalIncomeForCourse - teacherShareForCourse);

                    // record them in db
                    course.TotalIncome = totalIncomeForCourse;
                    course.TeacherPercent = teacherPercent;
                    course.TotalPayment = teacherShareForCourse;
                    course.TotalInstitutePayment = instutudeShareForCourse;

                    _courseService.UpdateCourse(course, null, null, null);
                }
                else
                {
                    var teacherTotalPayments = (TeacherTotalPaymentForCourse(teacherId, courseId));
                    // new income = allincomeforcourse - (teacherTotalPayment + instituteTotalShare)
                    var newCourseIncome = (totalIncomeForCourse - (teacherTotalPayments + GetInstitudeShared(totalIncomeForCourse, teacherTotalPayments))) - course.TotalIncome.Value;
                    var teacherShareForCourse = (newCourseIncome * teacherPercent) / 100;
                    var instutudeShareForCourse = (newCourseIncome - teacherShareForCourse);

                    course.TotalIncome = newCourseIncome;
                    course.TeacherPercent = teacherPercent;
                    course.TotalPayment = teacherShareForCourse;
                    course.TotalInstitutePayment = instutudeShareForCourse;

                    _courseService.UpdateCourse(course, null, null, null);
                }
            }
        }
        #endregion

        #region TeacherTotalIncome
        public int TeacherTotalIncome(int teacherId) => _db.OrderDetails
            .Include(od => od.Course)
            .Include(od => od.Order)
            .Where(od => od.Course.TeacherId == teacherId && od.Order.IsFinally == true)
            .Select(od => od.Order.TotalPrice).Sum();
        #endregion

        #region TotalIncomePerCourse
        public int TotalIncomeForCourse(int teacherId, int courseId) => _db.OrderDetails
            .Include(od => od.Course)
            .Include(od => od.Order)
            .Where(od => od.Course.TeacherId == teacherId && od.Course.CourseId == courseId && od.Order.IsFinally == true)
            .Select(od => od.Order.TotalPrice).Sum();
        #endregion

        #region TeacherTotalPaymentForCourse
        public int TeacherTotalPaymentForCourse(int teacherId, int courseId) => _db.Payments.Where(p => p.TeacherId == teacherId && p.CourseId == courseId).Select(p => p.Amount).Sum();
        #endregion

        #region RemainingTeacherShareForCourse
        public int RemainingTeacherShareForCourse(int teacherId, int courseId) 
        {
            var teacherIncomeForCourse = TeacherIncomeForCourse(teacherId, courseId);
            var teacherPaymentForCourse = TeacherTotalPaymentForCourse(teacherId, courseId);

            return teacherIncomeForCourse - teacherPaymentForCourse;
        }
        #endregion

        #region TeacherIncomeForCourse
        public int TeacherIncomeForCourse(int teacherId, int courseId)
        {
            var course = _courseService.GetCourseById(courseId);

            if (course.TeacherPercent != null)
            {
                return (int)((TotalIncomeForCourse(teacherId, courseId) * course.TeacherPercent) / 100);
            }
            else {
                return 0;
            }
        }
        #endregion

        #region TeacherTotalIncomeForCourse
        public int TeacherTotalIncomeForCourse(int teacherId, int courseId) => _db.OrderDetails
            .Include(od => od.Course)
            .Include(od => od.Order)
            .Where(od => od.Course.TeacherId == teacherId && od.Course.CourseId == courseId && od.Order.IsFinally == true).Select(od => od.Order.TotalPrice).Sum();
        #endregion

        private int GetInstitudeShared(int totalIncome, int teacherShare) => totalIncome - teacherShare;
    }
}
