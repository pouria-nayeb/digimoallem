using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.DAL.Entities.Accounting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IAccountingService : IDisposable
    {
        #region AddPayment
        bool AddPayment(Payment payemt);
        Task<bool> AddPaymentAsync(Payment payemt);
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

        #region GetTeacherCourse
        int TeacherShare(int price, int percent);
        #endregion

        #region InstitudeShare
        int InstitudeShare(int price, int percent);
        #endregion

        #region GetTeacherPayment
        int GetTeacherPayment(int teacherId);
        #endregion

        #region GetTotalIncome
        int GetTotalIncome(int teacherId, int courseId);
        #endregion

        #region GetTeacherIncome
        int GetTeacherIncome(int teacherId);
        #endregion

        #region GetTeacherTotalIncome
        int GetTeacherTotalIncome(int teacherId, int courseId);
        #endregion

        #region GetTeacherTotalIncome
        int GetInstitudeTotalIncome(int teacherId, int courseId);
        #endregion

        // purification
        #region GetPurifications
        PurificationPagingViewModel GetPurifications(int pageNumber = 1, int pageSize = 32);
        #endregion

        #region GetPurificationById
        Purification GetPurificationById(int purificationId);
        #endregion

        #region AddPurification
        Purification AddPurification(Purification purification);
        #endregion

        #region UpdatePurification
        Purification UpdatePurification(Purification purification);
        #endregion

        #region RemovePurification
        Purification RemovePurification(int purificationId);
        #endregion

        #region SearchPurification
        List<Purification> SearchPurification(string query);
        #endregion

        #region PurificationsCount
        int PurificationsCount();
        #endregion

        #region UncheckedPurificationsCount
        int UncheckedPurificationsCount();
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}
