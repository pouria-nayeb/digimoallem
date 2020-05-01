using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.DAL.Entities.Accounting;
using System;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IAccountingService : IDisposable
    {
        #region AddPayment
        bool AddPayment(Payment payemt);
        Task<bool> AddPaymentAsync(Payment payemt);
        #endregion

        #region AddTeacherPercent
        bool AddTeacherPercent(TeacherPercentViewModel teacherPercentVM);
        Task<bool> AddTeacherPercentAsync(TeacherPercentViewModel teacherPercentVM);
        #endregion

        #region GetTeacherPaymentsByUsername
        TeacherPaymentViewModel GetTeacherPaymentByUserName(int userId, int pageNumber = 1, int pageSize = 32);
        Task<TeacherPaymentViewModel> GetTeacherPaymentByUserNameAsync(int userId, int pageNumber = 1, int pageSize = 32);
        #endregion

        #region GetPaymentById
        Payment GetPaymentById(int paymentId);
        Task<Payment> GetPaymentByIdAsync(int paymentId);
        #endregion

        #region UpdatePayment
        bool UpdatePayment(Payment payment);
        Task<bool> UpdatePaymentAsync(Payment payment);
        #endregion

        #region GetPayments
        AccountingViewModel GetPayments(int pageId = 1, int pageSize = 20);
        Task<AccountingViewModel> GetPaymentsAsync(int pageId = 1, int pageSize = 20);
        #endregion

        #region RemovePayment
        bool RemovePayment(int paymentId);
        Task<bool> RemovePaymentAsync(int paymentId);
        #endregion

        #region PaymentsCount
        int PaymentsCount();
        Task<int> PaymentCountsAsync();
        #endregion

        #region TeacherTotalPayments
        int TeacherTotalPayments(int teacherId);
        Task<int> TeacherTotalPaymentsAsync(int teacherId);
        #endregion

        #region TeacherTotalIncome
        int TeacherTotalIncome(int teacherId);
        #endregion

        #region TeacherTotalIncomePerCourse
        int TotalIncomeForCourse(int teacherId, int courseId);
        #endregion

        #region CourseSharesCalculator
        void CourseSharesCalculator(int teacherId, int courseId, int teacherPercent);
        #endregion

        #region TeacherTotalPaymentForCourse
        int TeacherTotalPaymentForCourse(int teacherId, int courseId);
        #endregion

        #region TeacherIncomeForCourse
        int TeacherIncomeForCourse(int teacherId, int courseId);
        #endregion

        #region RemainingTeacherShareForCourse
        int RemainingTeacherShareForCourse(int teacherId, int courseId);
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}
