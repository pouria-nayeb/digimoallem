using DigiMoallem.BLL.DTOs.Accounts;
using DigiMoallem.BLL.DTOs.Admin.Users;
using DigiMoallem.BLL.DTOs.Transactions;
using DigiMoallem.BLL.DTOs.UserPanel;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Transactions;
using DigiMoallem.DAL.Entities.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _db;

        public UserService(ApplicationDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Check uniqueness of username
        /// </summary>
        /// <param name="userName"></param>
        #region CheckUserNameExistance
        public bool IsUserNameExist(string userName)
        {
            return _db.Users.Any(u => u.UserName == userName);
        }
        public async Task<bool> IsUserNameExistAsync(string userName)
        {
            return await _db.Users.AnyAsync(u => u.UserName == userName);
        }
        #endregion

        /// <summary>
        /// Check uniqueness of email address
        /// </summary>
        /// <param name="email"></param>
        #region CheckEmailExistance
        public bool IsEmailExist(string email)
        {
            return _db.Users.Any(u => u.Email == email);
        }
        public async Task<bool> IsEmailExistAsync(string email)
        {
            return await _db.Users.AnyAsync(u => u.Email == email);
        }
        #endregion

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId"></param>
        #region GetUserById
        public User GetUserById(int userId)
        {
            return _db.Users.IgnoreQueryFilters().SingleOrDefault(u => u.UserId == userId);
        }
        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _db.Users.IgnoreQueryFilters().SingleOrDefaultAsync(u => u.UserId == userId);
        }
        #endregion

        /// <summary>
        /// Get user by username
        /// </summary>
        /// <param name="userName"></param>
        #region GetUserByUserName
        public User GetUserByUserName(string userName)
        {
            return _db.Users.SingleOrDefault(u => u.UserName == userName.TextTransform());
        }
        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            return await _db.Users.SingleOrDefaultAsync(u => u.UserName == userName.TextTransform());
        }
        #endregion

        /// <summary>
        /// Add new user to database
        /// </summary>
        /// <param name="user"></param>
        #region AddUser
        public int AddUser(User user)
        {
            try
            {
                // db success
                _db.Users.Add(user);
                Save();
                return user.UserId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        public async Task<int> AddUserAsync(User user)
        {
            try
            {
                // db success
                await _db.Users.AddAsync(user);
                await SaveAsync();
                return user.UserId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        #region RolesCount
        public int RolesCount() => _db.Roles.Count();

        public async Task<int> RolesCountAsync() => await _db.Roles.CountAsync();
        #endregion

        /// <summary>
        /// Authenticate the user in system
        /// </summary>
        /// <param name="login"></param>
        #region LoginUser
        public User LoginUser(LoginViewModel login)
        {
            string password = login.Password.EncodePassword();
            string email = login.Email.TextTransform();

            return _db.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
        }
        public async Task<User> LoginUserAsync(LoginViewModel login)
        {
            string password = login.Password.EncodePassword();
            string email = login.Email.TextTransform();

            return await _db.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
        }
        #endregion

        /// <summary>
        /// Active user account with a disposible token
        /// </summary>
        /// <param name="activeCode"></param>
        #region ActiveAccount
        public bool ActiveAccount(string activeCode)
        {
            var user = _db.Users.SingleOrDefault(u => u.ActivationCode == activeCode);
            if (user == null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActivationCode = CodeGenerator.GenerateUniqueCode();
            Save();
            return true;
        }
        public async Task<bool> ActiveAccountAsync(string activeCode)
        {
            var user = await _db.Users.SingleOrDefaultAsync(u => u.ActivationCode == activeCode);
            if (user == null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActivationCode = CodeGenerator.GenerateUniqueCode();
            await SaveAsync();
            return true;
        }
        #endregion

        /// <summary>
        /// Get user by email address
        /// </summary>
        /// <param name="email"></param>
        #region GetUserByEmail
        public User GetUserByEmail(string email)
        {
            return _db.Users.SingleOrDefault(u => u.Email == email.TextTransform());
        }
        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _db.Users.SingleOrDefaultAsync(u => u.Email == email.TextTransform());
        }
        #endregion

        #region GetUserByPhoneNumber
        public User GetUserByPhoneNumber(string phoneNumber) => _db.Users
            .FirstOrDefault(u => u.PhoneNumber == phoneNumber.Trim());
        #endregion

        #region GetUserByToken
        public User GetUserByToken(string phoneNumber, string token) => _db.Users
            .FirstOrDefault(u => u.PhoneNumber == phoneNumber.Trim() && u.Token == token);
        #endregion

        #region GetAllUsers
        public List<User> GetAllUsers() => _db.Users.ToList();
        #endregion

        /// <summary>
        /// Get user id by userName
        /// </summary>
        /// <param name="userName"></param>
        #region GetUserIdByUserName
        public int GetUserIdByUserName(string userName)
        {
            return _db.Users.IgnoreQueryFilters().SingleOrDefault(u => u.UserName == userName.TextTransform()).UserId;
        }

        public async Task<int> GetUserIdByUserNameAsync(string userName)
        {
            var user = await _db.Users.IgnoreQueryFilters().SingleOrDefaultAsync(u => u.UserName == userName.TextTransform());
            return user.UserId;
        }
        #endregion

        /// <summary>
        /// Get User By ActivationCode
        /// </summary>
        /// <param name="activationCode"></param>
        #region GetUserByActivationCode
        public User GetUserByActivationCode(string activationCode)
        {
            return _db.Users.SingleOrDefault(u => u.ActivationCode == activationCode);
        }
        public async Task<User> GetUserByActivationCodeAsync(string activationCode)
        {
            return await _db.Users.SingleOrDefaultAsync(u => u.ActivationCode == activationCode);
        }
        #endregion

        /// <summary>
        /// Update user data
        /// </summary>
        /// <param name="user"></param>
        #region UpdateUser
        public bool UpdateUser(User user)
        {
            try
            {
                // db success
                _db.Users.Update(user);
                Save();
                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        public async Task<bool> UpdateUserAsync(User user)
        {
            try
            {
                // db success
                _db.Users.Update(user);
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

        #region UserSelectList
        public List<SelectListItem> GetUserSelectList() => _db.Users.Select(u => new SelectListItem
        {
            Text = u.Email,
            Value = u.UserId.ToString()
        }).ToList();

        public async Task<List<SelectListItem>> GetUserSelectListAsync() => await _db.Users.Select(u => new SelectListItem
        {
            Text = u.Email,
            Value = u.UserId.ToString()
        }).ToListAsync();
        #endregion

        /// <summary>
        /// Get user information to display in userpanel
        /// </summary>
        /// <param name="userName"></param>
        #region GetUserDetailsByUserName
        public UserPanelViewModel GetUserDetails(string userName)
        {
            var user = GetUserByUserName(userName);

            return new UserPanelViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                RegisterDate = user.RegisterDate,
                Balance = GetUserBalance(userName),
                Description = user.Description,
                Skills = user.Skills,
                Experiences = user.Experiences,
                ScientificField = user.ScientificField,
                CardNumber = user.CardNumber,
                EducationalLevel = user.EducationalLevel,
                Sheba = user.Sheba,
                UpdateDate = user.UpdateDate.Value
            };
        }

        public async Task<UserPanelViewModel> GetUserDetailsAsync(string userName)
        {
            var user = await GetUserByUserNameAsync(userName);

            return new UserPanelViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                RegisterDate = user.RegisterDate,
                Balance = await GetUserBalanceAsync(userName),
                Description = user.Description,
                Skills = user.Skills,
                Experiences = user.Experiences,
                ScientificField = user.ScientificField,
                CardNumber = user.CardNumber,
                EducationalLevel = user.EducationalLevel,
                Sheba = user.Sheba,
                UpdateDate = user.UpdateDate.Value
            };
        }
        #endregion

        /// <summary>
        /// Get User Details By Id
        /// </summary>
        /// <param name="userId"></param>
        #region GetUserDetailsById
        public UserPanelViewModel GetUserDetails(int userId)
        {
            var user = GetUserById(userId);

            return new UserPanelViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                RegisterDate = user.RegisterDate,
                Balance = GetUserBalance(user.UserName)
            };
        }

        public async Task<UserPanelViewModel> GetUserDetailsAsync(int userId)
        {
            var user = await GetUserByIdAsync(userId);

            return new UserPanelViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                RegisterDate = user.RegisterDate,
                Balance = await GetUserBalanceAsync(user.UserName)
            };
        }
        #endregion

        /// <summary>
        /// Get details to edit user profile
        /// </summary>
        /// <param name="userName"></param>
        #region GetDetailsToEditUserProfile
        public EditProfileViewModel GetDetailsToEditUserProfile(string userName)
        {
            var user = GetUserByUserName(userName);
            return new EditProfileViewModel()
            {
                Email = user.Email,
                ImageName = user.UserAvatar,
                PhoneNumber = user.PhoneNumber,          
                FirstName = user.FirstName,
                LastName = user.LastName,
                Description = user.Description,
                Skills = user.Skills,
                Experiences = user.Experiences,
                ScientificField = user.ScientificField,                
                CardNumber = user.CardNumber,
                EducationalLevel = user.EducationalLevel,
                Sheba = user.Sheba
            };
        }
        public async Task<EditProfileViewModel> GetDetailsToEditUserProfileAsync(string userName)
        {
            var user = await GetUserByUserNameAsync(userName);
            return new EditProfileViewModel()
            {
                Email = user.Email,
                ImageName = user.UserAvatar,
                PhoneNumber = user.PhoneNumber,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Description = user.Description,
                Skills = user.Skills,
                Experiences = user.Experiences,
                ScientificField = user.ScientificField,
                CardNumber = user.CardNumber,
                EducationalLevel =user.EducationalLevel,
                Sheba = user.Sheba
            };
        }
        #endregion

        /// <summary>
        /// Edit user information
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="profile"></param>
        #region UpdateProfile
        public bool UpdateProfile(string userName, EditProfileViewModel profile)
        {
            try
            {
                // update user profile information
                var user = GetUserByUserName(userName);
                user.Email = profile.Email.TextTransform();

                user.FirstName = profile.FirstName;
                user.LastName = profile.LastName;
                user.Description = profile.Description;
                user.Skills = profile.Skills;
                user.Experiences = profile.Experiences;
                user.ScientificField = profile.ScientificField;

                user.UserAvatar = ImageUpload(user, profile.UserAvatar);

                user.PhoneNumber = profile.PhoneNumber;

                return UpdateUser(user);
            }
            catch
            {

                return false;
            }
        }
        public async Task<bool> UpdateProfileAsync(string userName, EditProfileViewModel profile)
        {
            try
            {
                // update user profile information
                var user = GetUserByUserName(userName);
                user.Email = profile.Email.TextTransform();

                user.FirstName = profile.FirstName;
                user.LastName = profile.LastName;
                user.Description = profile.Description;
                user.Skills = profile.Skills;
                user.Experiences = profile.Experiences;
                user.ScientificField = profile.ScientificField;

                user.UserAvatar = ImageUpload(user, profile.UserAvatar);

                user.PhoneNumber = profile.PhoneNumber;

                user.EducationalLevel = profile.EducationalLevel;
                user.CardNumber = profile.CardNumber;
                user.Sheba = profile.Sheba;

                return await UpdateUserAsync(user);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Check if current password for specific user is valid
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="userName"></param>
        #region CompareOldPassword
        public bool CompareOldPassword(string oldPassword, string userName)
        {
            var hashPassword = oldPassword.EncodePassword();
            return _db.Users.Any(u => u.Password == hashPassword && u.UserName == userName.TextTransform());
        }

        public async Task<bool> CompareOldPasswordAsync(string oldPassword, string userName)
        {
            var hashPassword = oldPassword.EncodePassword();
            return await _db.Users.AnyAsync(u => u.Password == hashPassword && u.UserName == userName.TextTransform());
        }
        #endregion

        /// <summary>
        /// Change user password
        /// </summary>
        /// <param name="password"></param>
        /// <param name="newPassword"></param>
        #region ChangeUserPassword
        public bool ChangeUserPassword(string userName, string newPassword)
        {
            try
            {
                // db success
                var user = GetUserByUserName(userName);

                user.Password = newPassword.EncodePassword();

                UpdateUser(user);

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }
        public async Task<bool> ChangeUserPasswordAsync(string userName, string newPassword)
        {
            try
            {
                // db success
                var user = await GetUserByUserNameAsync(userName);

                user.Password = newPassword.EncodePassword();

                await UpdateUserAsync(user);

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
        /// Calculate user balance
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        #region GetUserBalance
        public int GetUserBalance(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            var user = GetUserById(userId);

            var desposit = _db.Exchanges
                .Where(t => t.UserId == userId && t.TransactionTypeId == 1 && t.IsPay == true)
                .Select(t => t.Amount)
                .ToList();

            var withdraw = _db.Exchanges
                .Where(t => t.UserId == userId && t.TransactionTypeId == 2)
                .Select(t => t.Amount)
                .ToList();

            user.Balance = desposit.Sum() - withdraw.Sum();
            UpdateUser(user);

            return (desposit.Sum() - withdraw.Sum());
        }

        public async Task<int> GetUserBalanceAsync(string userName)
        {
            int userId = await GetUserIdByUserNameAsync(userName);
            var user = await GetUserByIdAsync(userId);

            var desposit = await _db.Exchanges
                .Where(t => t.UserId == userId && t.TransactionTypeId == 1 && t.IsPay == true)
                .Select(t => t.Amount)
                .ToListAsync();

            var withdraw = await _db.Exchanges
                .Where(t => t.UserId == userId && t.TransactionTypeId == 2)
                .Select(t => t.Amount)
                .ToListAsync();

            user.Balance = desposit.Sum() - withdraw.Sum();
            await UpdateUserAsync(user);

            return (desposit.Sum() - withdraw.Sum());
        }
        #endregion

        /// <summary>
        /// Get 15-TOP user transactions based on transaction date
        /// </summary>
        /// <param name="userName"></param>
        #region GetUserTransactions
        public List<TransactionViewModel> GetUserTransactions(string userName)
        {
            var userId = GetUserIdByUserName(userName.TextTransform());

            return _db.Exchanges
                .Where(t => t.UserId == userId && t.IsPay == true)
                .OrderByDescending(t => t.TransactionDate)
                .Take(15)
                .Select(t => new TransactionViewModel
                {
                    Amount = t.Amount,
                    TransactionType = t.TransactionTypeId,
                    TransactionDate = t.TransactionDate,
                    Description = t.Description ?? "-"
                })
                .ToList();
        }

        public async Task<List<TransactionViewModel>> GetUserTransactionsAsync(string userName)
        {
            var userId = await GetUserIdByUserNameAsync(userName.TextTransform());

            return await _db.Exchanges
                .Where(t => t.UserId == userId && t.IsPay == true)
                .OrderByDescending(t => t.TransactionDate)
                .Take(15)
                .Select(t => new TransactionViewModel
                {
                    Amount = t.Amount,
                    TransactionType = t.TransactionTypeId,
                    TransactionDate = t.TransactionDate,
                    Description = t.Description ?? "-"
                })
                .ToListAsync();
        }
        #endregion

        /// <summary>
        /// Charge user account
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="amount"></param>
        /// <param name="description"></param>
        /// <param name="isPay"></param>
        #region ChargeUserAccount
        public int ChargeUserAccount(string userName, int amount, string description, bool isPay = false)
        {
            try
            {
                // db success
                Exchange transaction = new Exchange()
                {
                    Amount = amount,
                    UserId = GetUserIdByUserName(userName),
                    IsPay = isPay,
                    TransactionTypeId = 1,
                    Description = description,
                    TransactionDate = DateTime.Now
                };

                return AddTransaction(transaction);
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        public async Task<int> ChargeUserAccountAsync(string userName, int amount, string description, bool isPay = false)
        {
            try
            {
                // db success
                Exchange transaction = new Exchange()
                {
                    Amount = amount,
                    UserId = GetUserIdByUserName(userName),
                    IsPay = isPay,
                    TransactionTypeId = 1,
                    Description = description,
                    TransactionDate = DateTime.Now
                };

                return await AddTransactionAsync(transaction);
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Add new transaction
        /// </summary>
        /// <param name="transaction"></param>
        #region AddTransaction
        public int AddTransaction(Exchange transaction)
        {
            try
            {
                // db success
                _db.Exchanges.Add(transaction);
                Save();

                return transaction.ExchangeId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        public async Task<int> AddTransactionAsync(Exchange transaction)
        {
            try
            {
                // db success
                await _db.Exchanges.AddAsync(transaction);
                await SaveAsync();

                return transaction.ExchangeId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Get transaction by transaction id
        /// </summary>
        /// <param name="transactionId"></param>
        #region GetTransactionByTransactionId
        public Exchange GetTransactionByTransactionId(int? transactionId)
        {
            return _db.Exchanges.SingleOrDefault(t => t.ExchangeId == transactionId);
        }

        public async Task<Exchange> GetTransactionByTransactionIdAsync(int? transactionId)
        {
            return await _db.Exchanges.SingleOrDefaultAsync(t => t.ExchangeId == transactionId);
        }
        #endregion

        /// <summary>
        /// Update transaction
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        #region UpdateTransaction
        public bool UpdateTransaction(Exchange transaction)
        {
            try
            {
                // db success
                _db.Exchanges.Update(transaction);
                Save();

                return true;
            }
            catch
            {
                // db failed
                return false;
            }
        }

        public async Task<bool> UpdateTransactionAsync(Exchange transaction)
        {
            try
            {
                // db success
                _db.Exchanges.Update(transaction);
                await SaveAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion



        /// <summary>
        /// Get all users to manage
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="filterEmail"></param>
        /// <param name="filterUserName"></param>
        #region GetUser - Pagination - filterByEmail - filterByUserName
        public UserViewModel GetUsers(int pageId, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> users = _db.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail.TextTransform()));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName.TextTransform()));
            }

            // pagination logic
            int recordsPerPages = 32;
            int skip = (pageId - 1) * recordsPerPages;

            int usersCount = users.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(usersCount, recordsPerPages));

            var userVM = new UserViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Users = users.OrderByDescending(u => u.RegisterDate)
                .Skip(skip)
                .Take(recordsPerPages)
                .AsNoTracking()
                .ToList()
            };

            return userVM;
        }
        public async Task<UserViewModel> GetUsersAsync(int pageId, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> users = _db.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail.TextTransform()));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName.TextTransform()));
            }

            // pagination logic
            int recordsPerPage = 32;
            int skip = (pageId - 1) * recordsPerPage;

            int usersCount = users.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(usersCount, recordsPerPage));

            var userVM = new UserViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Users = await users.OrderByDescending(u => u.RegisterDate)
                .Skip(skip)
                .Take(recordsPerPage)
                .AsNoTracking()
                .ToListAsync()
            };

            return userVM;
        }
        #endregion

        /// <summary>
        /// Get list of all deleted users
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="filterEmail"></param>
        /// <param name="filterUserName"></param>
        #region GetDeletedUser - Pagination - filterByEmail - filterByUserName
        public UserViewModel GetDeletedUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> users = _db.Users;

            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail.TextTransform()));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName.TextTransform()));
            }

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            var userVM = new UserViewModel()
            {
                CurrentPage = pageId,
                PageCount = users.Count() / recordsPerPages,
                Users = users.Where(u => u.IsDelete == true)
                .OrderByDescending(u => u.RegisterDate)
                .Skip(skip)
                .Take(recordsPerPages)
                .ToList()
            };

            return userVM;
        }
        public async Task<UserViewModel> GetDeletedUsersAsync(int pageId = 1,
            string filterEmail = "",
            string filterUserName = "")
        {
            IQueryable<User> users = _db.Users.IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail.TextTransform()));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName.TextTransform()));
            }

            // pagination logic
            int recordsPerPage = 20;
            int skip = (pageId - 1) * recordsPerPage;

            var userVM = new UserViewModel()
            {
                CurrentPage = pageId,
                PageCount = users.Count() / recordsPerPage,
                Users = await users.OrderByDescending(u => u.RegisterDate)
                .Where(u => u.IsDelete == true)
                .Skip(skip)
                .Take(recordsPerPage)
                .ToListAsync()
            };

            return userVM;
        }
        #endregion

        #region GetTeachers

        public UserViewModel GetTeachers(int pageId, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> users = _db.Users
                .Where(u => u.UserInRoles.Any(ur => ur.RoleId == 2 && u.IsDelete == false));

            if (!string.IsNullOrEmpty(filterEmail))
            {
                users = users.Where(u => u.Email.Contains(filterEmail.TextTransform()));
            }

            if (!string.IsNullOrEmpty(filterUserName))
            {
                users = users.Where(u => u.UserName.Contains(filterUserName.TextTransform()));
            }

            // pagination logic
            int recordsPerPages = 32;
            int skip = (pageId - 1) * recordsPerPages;

            int usersCount = users.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(usersCount, recordsPerPages));

            var userVM = new UserViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Users = users.OrderByDescending(u => u.RegisterDate)
                .Skip(skip)
                .Take(recordsPerPages)
                .AsNoTracking()
                .ToList()
            };

            return userVM;
        }

        #endregion

        /// <summary>
        /// Add user by admin
        /// </summary>
        /// <param name="user"></param>
        #region AddUserByAdmin
        public int AddUserByAdmin(CreateUserViewModel user)
        {
            var newUser = new User();
            newUser.Password = user.Password.EncodePassword();
            newUser.ActivationCode = CodeGenerator.GenerateUniqueCode();
            newUser.Email = user.Email;
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.IsActive = true;
            newUser.RegisterDate = DateTime.Now;
            newUser.UserName = user.UserName;
            newUser.Description = user.Description;
            newUser.ScientificField = user.ScientificField;
            newUser.EducationalLevel = user.EducationalLevel;
            newUser.CardNumber = user.CardNumber;
            newUser.Sheba = user.Sheba;

            newUser.UserAvatar = AddAndUplaodImage(newUser.UserAvatar, user.UserAvatar);

            return AddUser(newUser);
        }

        public async Task<int> AddUserByAdminAsync(CreateUserViewModel user)
        {
            var newUser = new User();
            newUser.Password = user.Password.EncodePassword();
            newUser.ActivationCode = CodeGenerator.GenerateUniqueCode();
            newUser.Email = user.Email;
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.IsActive = true;
            newUser.RegisterDate = DateTime.Now;
            newUser.UserName = user.UserName;
            newUser.Description = user.Description;
            newUser.ScientificField = user.ScientificField;
            newUser.EducationalLevel = user.EducationalLevel;
            newUser.CardNumber = user.CardNumber;
            newUser.Sheba = user.Sheba;

            newUser.UserAvatar = AddAndUplaodImage(newUser.UserAvatar, user.UserAvatar);

            return await AddUserAsync(newUser);
        }
        #endregion

        /// <summary>
        /// Delte user (soft) by admin
        /// </summary>
        /// <param name="userId"></param>
        #region DeleteUser
        public bool DeleteUser(int userId)
        {
            try
            {
                // db success
                var user = GetUserById(userId);

                user.IsDelete = true;

                return UpdateUser(user);
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            try
            {
                // db success
                var user = await GetUserByIdAsync(userId);

                user.IsDelete = true;

                return await UpdateUserAsync(user);
            }
            catch
            {
                // db failure
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Recover deleted user by admin
        /// </summary>
        /// <param name="userId"></param>
        #region RecoverDeletedUser
        public bool RecoverDeletedUser(int userId)
        {
            try
            {
                var user = GetUserById(userId);
                user.IsDelete = false;
                return UpdateUser(user);
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> RecoverDeletedUserAsync(int userId)
        {
            try
            {
                var user = await GetUserByIdAsync(userId);
                user.IsDelete = false;
                return await UpdateUserAsync(user);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Upadte user by admin
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        #region UpdateUser
        public bool UpdateUserByAdmin(EditUserViewModel model)
        {
            try
            {
                var user = GetUserById(model.UserId);

                user.Email = model.Email;

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.ScientificField = model.ScientificField;
                user.IsActive = true;
                user.Sheba = model.Sheba;
                user.CardNumber = model.CardNumber;
                user.EducationalLevel = model.EducationalLevel;

                if (!string.IsNullOrEmpty(model.Password))
                {
                    user.Password = model.Password.EncodePassword();
                }

                user.UserAvatar = ImageUpload(user, model.UserAvatar);

                return UpdateUser(user); ;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateUserByAdminAsync(EditUserViewModel model)
        {
            try
            {
                var user = await GetUserByIdAsync(model.UserId);

                user.Email = model.Email;

                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.ScientificField = model.ScientificField;
                user.Skills = model.Skills;
                user.Experiences = model.Experiences;
                user.IsActive = true;
                user.Sheba = model.Sheba;
                user.CardNumber = model.CardNumber;
                user.EducationalLevel = model.EducationalLevel;

                if (!string.IsNullOrEmpty(model.Password))
                {
                    user.Password = model.Password.EncodePassword();
                }

                user.UserAvatar = ImageUpload(user, model.UserAvatar);

                return await UpdateUserAsync(user);
            }
            catch
            {
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Update user details
        /// </summary>
        /// <param name="userId"></param>
        #region EditUserDetailsById
        public EditUserViewModel GetUserDetailsForEdit(int id)
        {
            return _db.Users.Where(u => u.UserId == id).Select(u => new EditUserViewModel
            {
                UserId = u.UserId,
                UserName = u.UserName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                AvatarName = u.UserAvatar,
                Description = u.Description,
                Skills = u.Skills,
                Experiences = u.Experiences,
                CardNumber = u.CardNumber,
                EducationalLevel = u.EducationalLevel,
                Sheba = u.Sheba,
                ScientificField = u.ScientificField,         
                Roles = u.UserInRoles.Select(r => r.RoleId).ToList()
            }).Single();
        }

        public async Task<EditUserViewModel> GetUserDetailsForEditAsync(int id)
        {
            return await _db.Users.Where(u => u.UserId == id).Select(u => new EditUserViewModel
            {
                UserId = u.UserId,
                UserName = u.UserName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                AvatarName = u.UserAvatar,
                Description = u.Description,
                Skills = u.Skills,
                Experiences = u.Experiences,
                ScientificField = u.ScientificField,
                CardNumber = u.CardNumber,
                EducationalLevel = u.EducationalLevel,
                Sheba = u.Sheba,
                Roles = u.UserInRoles.Select(r => r.RoleId).ToList()
            }).SingleAsync();
        }
        #endregion

        /// <summary>
        /// Users count
        /// </summary>
        /// <returns></returns>
        #region UsersCount
        public int UsersCount() => _db.Users
            .Count(u => u.IsDelete == false);

        public async Task<int> UsersCountAsync() => await _db.Users
            .CountAsync(u => u.IsDelete == false);
        #endregion

        #region TeachersCount
        public int TeachersCount() => _db.Users
            .Count(u => u.UserInRoles.Any(ur => ur.RoleId == 2 && u.IsDelete == false));

        public async Task<int> TeachersCountAsync() => await _db.Users
            .CountAsync(u => u.UserInRoles.Any(ur => ur.RoleId == 2 && u.IsDelete == false));

        #endregion

        #region Helpers
        /// <summary>
        /// Add and upload an image
        /// </summary>
        /// <param name="imageName"></param>
        /// <param name="ImageFile"></param>
        public string AddAndUplaodImage(string imageName, IFormFile imageFile) {
            if (imageFile != null)
            {
                string imagePath = string.Empty;
                imageName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(imageFile.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/Avatars/" + imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                return imageName;
            }
            else
            {
                return "default.png";
            }
        }

        /// <summary>
        /// Edit Uploaded image
        /// </summary>
        /// <param name="imageName"></param>
        /// <param name="fileName"></param>
        public string ImageUpload(User user, IFormFile fileName)
        {
            if (fileName != null)
            {
                if (user.UserAvatar.TextTransform() != "default.png")
                {
                    string oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatars/", user.UserAvatar);
                    if (File.Exists(oldImagePath))
                    {
                        File.Delete(oldImagePath);
                    }
                }

                string imageName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(fileName.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/avatars/" + imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    fileName.CopyTo(stream);
                }

                return imageName;
            }
            else
            {
                return user.UserAvatar;
            }
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
    }
}
