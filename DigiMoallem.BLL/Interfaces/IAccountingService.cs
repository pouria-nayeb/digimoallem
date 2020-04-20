using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.DAL.Entities.Accounting;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IAccountingService
    {
        #region AddPayment
        bool AddPayment(Payment payemt);
        Task<bool> AddPaymentAsync(Payment payemt);
        #endregion

        #region AddTeacherPercent
        bool AddTeacherPercent(TeacherPercentViewModel teacherPercentVM);
        Task<bool> AddTeacherPercentAsync(TeacherPercentViewModel teacherPercentVM);
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

        #region TeacherIncomePerCourse
        int TeacherIncomePerCourse(int teacherId, int courseId);
        Task<int> TeacherIncomePerCourseAsync(int teacherId, int courseId);
        #endregion

        #region TeacherRemainPayment
        int TeacherRemainPayment(int teacherId,int courseId);
        Task<int> TeacherRemainPaymentAsync(int teacherId, int courseId);
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}
