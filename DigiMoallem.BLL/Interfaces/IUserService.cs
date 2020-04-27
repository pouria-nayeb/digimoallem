using DigiMoallem.BLL.DTOs.Accounts;
using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.DTOs.Transactions;
using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.DAL.Entities.Transactions;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        // users
        #region CheckUserNameExistance
        bool IsUserNameExist(string userName);
        Task<bool> IsUserNameExistAsync(string userName);
        #endregion

        #region CheckEmailExistance
        bool IsEmailExist(string email);
        Task<bool> IsEmailExistAsync(string email);
        #endregion

        #region GetUserById
        User GetUserById(int userId);
        Task<User> GetUserByIdAsync(int userId);
        #endregion

        #region GetUserByUserName
        User GetUserByUserName(string userName);
        Task<User> GetUserByUserNameAsync(string userName);
        #endregion

        #region GetUserIdByUserName
        int GetUserIdByUserName(string userName);
        Task<int> GetUserIdByUserNameAsync(string userName);
        #endregion

        #region AddUser
        int AddUser(User user);
        Task<int> AddUserAsync(User user);
        Task<bool> UpdateUserByAdminAsync(EditUserViewModel editUserViewModel);
        #endregion

        #region LoginUser
        User LoginUser(LoginViewModel login);
        Task<User> LoginUserAsync(LoginViewModel login);
        #endregion

        #region ActiveAccount
        bool ActiveAccount(string activeCode);
        Task<bool> ActiveAccountAsync(string activeCode);
        #endregion

        #region GetUserByEmail
        User GetUserByEmail(string email);
        Task<User> GetUserByEmailAsync(string email);
        #endregion

        #region GetUserByActivationCode
        User GetUserByActivationCode(string activationCode);
        Task<User> GetUserByActivationCodeAsync(string activationCode);
        #endregion

        #region UpdateUser
        bool UpdateUser(User user);
        Task<bool> UpdateUserAsync(User user);
        #endregion

        #region UserSelectList
        List<SelectListItem> GetUserSelectList();
        Task<List<SelectListItem>> GetUserSelectListAsync();
        #endregion

        // userpanel
        #region GetUserDetailsByUserName
        UserPanelViewModel GetUserDetails(string userName);
        Task<UserPanelViewModel> GetUserDetailsAsync(string userName);
        #endregion

        #region GetUserDetailsById
        UserPanelViewModel GetUserDetails(int userId);
        Task<UserPanelViewModel> GetUserDetailsAsync(int userId);
        #endregion

        #region GetDetailsToEditUserProfile
        EditProfileViewModel GetDetailsToEditUserProfile(string userName);
        Task<EditProfileViewModel> GetDetailsToEditUserProfileAsync(string userName);
        #endregion

        #region UpdateProfile
        bool UpdateProfile(string userName, EditProfileViewModel profile);
        Task<bool> UpdateProfileAsync(string userName, EditProfileViewModel profile);
        #endregion

        #region CompareOldPassword
        bool CompareOldPassword(string oldPassword, string userName);
        Task<bool> CompareOldPasswordAsync(string oldPassword, string userName);
        #endregion

        #region ChangeUserPassword
        bool ChangeUserPassword(string userName, string newPassword);
        Task<bool> ChangeUserPasswordAsync(string userName, string newPassword);
        #endregion

        #region RolesCount
        int RolesCount();
        Task<int> RolesCountAsync();
        #endregion

        // Transactions
        #region GetUserBalance
        int GetUserBalance(string userName);
        Task<int> GetUserBalanceAsync(string userName);
        #endregion

        #region GetUserTransactions
        List<TransactionViewModel> GetUserTransactions(string userName);
        Task<List<TransactionViewModel>> GetUserTransactionsAsync(string userName);
        #endregion

        #region ChargeUserAccount
        int ChargeUserAccount(string userName, int amount, string description, bool isPay = false);
        Task<int> ChargeUserAccountAsync(string userName, int amount, string description, bool isPay = false);
        #endregion

        #region AddTransaction
        int AddTransaction(Exchange transaction);
        Task<int> AddTransactionAsync(Exchange transaction);
        #endregion

        #region GetTransactionByTransactionId
        Exchange GetTransactionByTransactionId(int? transactionId);
        Task<Exchange> GetTransactionByTransactionIdAsync(int? transactionId);
        #endregion

        #region UpdateTransaction
        bool UpdateTransaction(Exchange transaction);
        Task<bool> UpdateTransactionAsync(Exchange transaction);
        #endregion

        // Admin
        #region GetUser - Pagination - filterByEmail - filterByUserName
        UserViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        Task<UserViewModel> GetUsersAsync(int pageId = 1, string filterEmail = "", string filterUserName = "");
        #endregion

        #region GetDeletedUser - Pagination - filterByEmail - filterByUserName
        UserViewModel GetDeletedUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        Task<UserViewModel> GetDeletedUsersAsync(int pageId = 1, string filterEmail = "", string filterUserName = "");
        #endregion

        #region AddUserByAdmin
        int AddUserByAdmin(CreateUserViewModel user);
        Task<int> AddUserByAdminAsync(CreateUserViewModel user);
        #endregion

        #region DeleteUser
        bool DeleteUser(int userId);
        Task<bool> DeleteUserAsync(int userId);
        #endregion

        #region RecoverDeletedUser
        bool RecoverDeletedUser(int userId);
        Task<bool> RecoverDeletedUserAsync(int userId);
        #endregion

        #region UpdateUserByAdmin
        EditUserViewModel GetUserDetailsForEdit(int userId);
        Task<EditUserViewModel> GetUserDetailsForEditAsync(int userId);
        #endregion

        #region UsersCount
        int UsersCount();
        Task<int> UsersCountAsync();
        #endregion

        #region TeachersCount
        int TeachersCount();
        Task<int> TeachersCountAsync();
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}
