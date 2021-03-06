﻿using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.BLL.Helpers.Converters;
using DigiMoallem.BLL.Helpers.Generators;
using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Context;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Services
{
    public class CourseService : ICourseService
    {
        private ApplicationDbContext _db;
        private IUserService _userService;

        public CourseService(ApplicationDbContext db, IUserService userService)
        {
            _db = db;
            _userService = userService;
        }

        /// <summary>
        /// Get groups
        /// </summary>
        /// <returns></returns>
        #region GetGroups
        public List<Group> GetGroups()
        {
            return _db.Groups.Include(g => g.Groups).AsNoTracking().ToList();
        }

        public async Task<List<Group>> GetGroupsAsync()
        {
            return await _db.Groups.Include(g => g.Groups).AsNoTracking().ToListAsync();
        }
        #endregion

        /// <summary>
        /// Get groups to manage course
        /// </summary>
        /// <returns></returns>
        #region GetGroupsToManageCourse
        public List<SelectListItem> GetGroupsToManageCourse()
        {
            return _db.Groups
                .Where(g => g.ParentId == null)
                .Select(g => new SelectListItem
                {
                    Text = g.Title,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public async Task<List<SelectListItem>> GetGroupsToManageCourseAsync()
        {
            return await _db.Groups
                .Where(g => g.ParentId == null)
                .Select(g => new SelectListItem
                {
                    Text = g.Title,
                    Value = g.GroupId.ToString()
                }).ToListAsync();
        }
        #endregion

        public List<int> GetCourseTypeByCourseId(int courseId)
        {
            return _db.CourseInCoursetypes
                .Where(cc => cc.CourseId == courseId)
                .Select(cc => cc.CourseTypeId)
                .ToList();
        }

        #region GetCourseTypeNameById
        public string GetCourseTypeNameById(int courseTypeId) => _db.CourseTypes.Single(ct => ct.CourseTypeId == courseTypeId).Title;
        #endregion

        /// <summary>
        /// Get subgroups to manage course
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        #region GetSubGroupsToManageCourse
        public List<SelectListItem> GetSubGroupsToManageCourse(int groupId)
        {
            return _db.Groups
                .Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem
                {
                    Text = g.Title,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public async Task<List<SelectListItem>> GetSubGroupsToManageCourseAsync(int groupId)
        {
            return await _db.Groups
                .Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem
                {
                    Text = g.Title,
                    Value = g.GroupId.ToString()
                }).ToListAsync();
        }
        #endregion

        /// <summary>
        /// Add group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        #region AddGroup
        public bool AddGroup(Group group, IFormFile formFile)
        {
            try
            {
                // successfully added to db
                group.ImageName = UploadIcon(formFile);

                _db.Groups.Add(group);
                Save();

                return true;
            }
            catch
            {
                // db error
                return false;
            }
        }

        public async Task<bool> AddGroupAsync(Group group, IFormFile formFile)
        {
            try
            {
                // successfully added to db
                group.ImageName = UploadIcon(formFile);

                await _db.Groups.AddAsync(group);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db error
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Get group by id
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        #region GetGroupById
        public Group GetGroupById(int groupId)
        {
            return _db.Groups.SingleOrDefault(g => g.GroupId == groupId);
        }

        public async Task<Group> GetGroupByIdAsync(int groupId)
        {
            return await _db.Groups.SingleOrDefaultAsync(g => g.GroupId == groupId);
        }
        #endregion

        /// <summary>
        /// Delete group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        #region DeleteGroup
        public bool DeleteGroup(Group group)
        {
            try
            {
                // db success
                _db.Groups.Remove(group);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> DeleteGroupAsync(Group group)
        {
            try
            {
                // db success
                RemoveGroupImage(group);

                _db.Groups.Remove(group);
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

        #region GetCoursesOfTeacher
        public CourseViewModel GetCoursesOfTeacher(int teacherId, int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<Course> courses = _db.Courses.Where(c => c.TeacherId == teacherId);

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, take));

            return new CourseViewModel
            {
                Courses = courses
                .Skip(skip)
                .Take(take)
                .OrderByDescending(c => c.CourseId)
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    ImageName = c.ImageName,
                    Title = c.Title,
                    TeacherId = c.TeacherId,
                    TeacherPercent = c.TeacherPercent
                }).ToList(),
                CurrentPage = pageNumber,
                PageCount = pagesCount
            };
        }
        #endregion

        /// <summary>
        /// Update group
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        #region UpdateGroup
        public bool UpdateGroup(Group group, IFormFile formFile)
        {
            try
            {
                // db success
                group.ImageName = ModifiedUploadIcon(group, formFile);

                _db.Groups.Update(group);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateGroupAsync(Group group, IFormFile formFile)
        {
            try
            {
                // db success
                group.ImageName = ModifiedUploadIcon(group, formFile);

                _db.Entry(group).State = EntityState.Modified;
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

        #region GetParentGroups
        public async Task<List<Group>> GetParentGroups() => await _db.Groups
            .Where(g => g.ParentId == null)
            .ToListAsync();
        #endregion

        #region GetUsersEmail
        public List<string> GetUsersEmail() => _db.Users.Select(e => e.Email).ToList();
        #endregion

        #region CoursesCount
        public int CoursesCount() => _db.Courses.Count();

        public async Task<int> CoursesCountAsync() => await _db.Courses.CountAsync();
        #endregion

        #region UncheckedCoursesCount
        public int UncheckedCoursesCount() => _db.Courses.Where(c => c.IsCheckedByAdmin == false).Count();
        #endregion

        public List<string> GetCourseTitles() => _db.Courses
            .Where(c => c.IsHidden == false)
            .Select(c => c.Title)
            .ToList();

        /// <summary>
        /// Get course levels
        /// </summary>
        /// <returns></returns>
        #region GetCourseLevels
        public List<SelectListItem> GetCourseLevels()
        {
            return _db.CourseLevels.Select(cl => new SelectListItem
            {
                Text = cl.Title,
                Value = cl.CourseLevelId.ToString()
            }).ToList();
        }

        public async Task<List<SelectListItem>> GetCourseLevelsAsync()
        {
            return await _db.CourseLevels.Select(cl => new SelectListItem
            {
                Text = cl.Title,
                Value = cl.CourseLevelId.ToString()
            }).ToListAsync();
        }
        #endregion

        /// <summary>
        /// Get course statuses
        /// </summary>
        /// <returns></returns>
        #region GetCourseStatuses
        public List<SelectListItem> GetCourseStatuses()
        {
            return _db.CourseStatuses.Select(cs => new SelectListItem
            {
                Text = cs.Title,
                Value = cs.CourseStatusId.ToString()
            }).ToList();
        }

        public async Task<List<SelectListItem>> GetCourseStatusesAsync()
        {
            return await _db.CourseStatuses.Select(cs => new SelectListItem
            {
                Text = cs.Title,
                Value = cs.CourseStatusId.ToString()
            }).ToListAsync();
        }
        #endregion

        #region IsFavoriteCourses
        public List<DisplayCourseViewModel> LatestFavoriteCourses() => _db.Courses
            .Where(c => c.IsFavorite == true)
            .OrderByDescending(c => c.CourseId)
            .Take(9)
            .Select(c => new DisplayCourseViewModel
            {
                CourseId = c.CourseId,
                ImageName = c.ImageName,
                GroupName = c.Group.Title,
                Price = c.Price,
                Title = c.Title,
                Off = c.Off,
                OffPercentage = c.OffPercent,
                PriceAfterOff = c.PriceAfterOff,
                TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
            })
            .ToList();
        #endregion

        #region TeacherTotalIncome
        public int TeacherTotalIncome(int teacherId) => _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .Where(c => c.Course.TeacherId == teacherId && c.Order.IsFinally == true)
                .Select(od => od.Order.TotalPrice).Sum();


        public async Task<int> TeacherTotalIncomeAsync(int teacherId) => await _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .Where(c => c.Course.TeacherId == teacherId && c.Order.IsFinally == true)
                .Select(od => od.Order.TotalPrice).SumAsync();
        #endregion

        /// <summary>
        /// Get course types
        /// </summary>
        /// <returns></returns>
        #region GetCourseStatuses
        public List<SelectListItem> GetCourseTypes()
        {
            return _db.CourseTypes.Select(cs => new SelectListItem
            {
                Text = cs.Title,
                Value = cs.CourseTypeId.ToString()
            }).ToList();
        }

        public async Task<List<SelectListItem>> GetCourseTypesAsync()
        {
            return await _db.CourseTypes.Select(cs => new SelectListItem
            {
                Text = cs.Title,
                Value = cs.CourseTypeId.ToString()
            }).ToListAsync();
        }
        #endregion

        #region GetAllUncheckedEpisodes
        public CourseEpisodesViewModel GetAllUncheckedEpisodes(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<CourseEpisode> courseEpisodes = _db.CourseEpisodes
                .Where(ep => ep.IsCheckedByAdmin == false);

            // pagination logic
            int take = 20;
            int skip = (pageNumber - 1) * take;

            int courseEpisodesCount = courseEpisodes.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(courseEpisodesCount, take));

            return new CourseEpisodesViewModel()
            {
                PageNumber = pageNumber,
                PagesCount = pagesCount,
                Episodes = courseEpisodes
                .Skip(skip)
                .Take(take)
                .OrderByDescending(u => u.CourseEpisodeId)
                .AsNoTracking()
                .ToList()
            };
        }
        #endregion

        /// <summary>
        /// Get teachers
        /// </summary>
        /// <returns></returns>
        #region GetTeachers
        public List<SelectListItem> GetTeachers()
        {
            return _db.UserInRoles
                .Where(ur => ur.RoleId == 2)
                .Include(ur => ur.User)
                .OrderByDescending(ur => ur.UserId)
                .Select(ur => new SelectListItem
                {
                    Text = ur.User.UserName,
                    Value = ur.UserId.ToString()
                })
                .ToList();
        }

        public async Task<List<SelectListItem>> GetTeachersAsync()
        {
            return await _db.UserInRoles
                .Where(ur => ur.RoleId == 2)
                .Include(ur => ur.User)
                .OrderByDescending(ur => ur.UserId)
                .Select(ur => new SelectListItem
                {
                    Text = $"{ur.User.UserId} - {ur.User.FirstName} {ur.User.LastName} - {ur.User.UserName}",
                    Value = ur.UserId.ToString()
                }).ToListAsync();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        /// <param name="imageCourse"></param>
        /// <param name="demoCourse"></param>
        /// <returns></returns>
        #region AddCourse
        public int AddCourse(Course course, IFormFile imageCourse, IFormFile demoCourse,
            List<int> courseTypes)
        {
            try
            {
                // db success
                course.CreateDate = DateTime.Now;

                course.ImageName = AddAndUplaodImage(course.ImageName, imageCourse);

                course.Demo = AddAndUplaodDemo(course.Demo, demoCourse);

                _db.Courses.Add(course);
                Save();
                return course.CourseId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }

        public async Task<int> AddCourseAsync(Course course,
            IFormFile imageCourse,
            IFormFile demoCourse,
            List<int> courseTypes)
        {
            try
            {
                // db success
                course.CreateDate = DateTime.Now;

                if (course.Off)
                {
                    course.PriceAfterOff = (int)(course.Price - ((course.Price * course.OffPercent) / 100));
                }

                course.ImageName = AddAndUplaodImage(course.ImageName, imageCourse);

                course.Demo = AddAndUplaodDemo(course.Demo, demoCourse);

                await _db.Courses.AddAsync(course);
                await SaveAsync();

                foreach (var courseTypeId in courseTypes)
                {
                    _db.CourseInCoursetypes.Add(new CourseInCourseType
                    {
                        CourseId = course.CourseId,
                        CourseTypeId = courseTypeId
                    });

                    _db.SaveChanges();
                }

                return course.CourseId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Get some course details to show in admin
        /// </summary>
        /// <returns></returns>
        #region GetCoursesForAdmin
        public CourseViewModel GetCoursesForAdmin(int pageId)
        {
            IQueryable<Course> courses = _db.Courses;

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .OrderByDescending(u => u.CourseId)
                .Skip(skip)
                .Take(recordsPerPages)
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    TeacherPercent = c.TeacherPercent,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToList()
            };
        }

        public async Task<CourseViewModel> GetCoursesForAdminAsync(int pageId)
        {
            IQueryable<Course> courses = _db.Courses;

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = await courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    TeacherPercent = c.TeacherPercent,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToListAsync()
            };
        }
        #endregion

        #region GetTeacherCoursesForAdminAsync
        public CourseViewModel GetTeacherCoursesForAdminAsync(int pageId, int teacherId)
        {
            IQueryable<Course> courses = _db.Courses;

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Where(c => c.TeacherId == teacherId)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    TeacherPercent = c.TeacherPercent,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToList()
            };
        }
        #endregion

        public CourseViewModel GetUncheckedCoursesForAdmin(int pageId)
        {
            IQueryable<Course> courses = _db.Courses.Where(c => c.IsCheckedByAdmin == false);

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    TeacherPercent = c.TeacherPercent,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToList()
            };
        }

        #region AdvanceSearchCourse
        public SearchOrderViewModel AdvanceSearchCourse(DateTime startDate, DateTime endDate, int teacherId, int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<OrderDetail> orderDetails = _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .ThenInclude(o => o.OrderDetails)
                .Where(c => c.Course.TeacherId == teacherId && c.Order.IsFinally == true);

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int orderDetailsCount = orderDetails.Count();
            int pagesCount = (int)Math.Ceiling(decimal.Divide(orderDetailsCount, take));

            if (startDate != null)
            {
                orderDetails = orderDetails.Where(od => od.Order.CreateDate >= startDate);
            }

            if (endDate != null)
            {
                orderDetails = orderDetails.Where(o => o.Order.CreateDate <= endDate);
            }

            return new SearchOrderViewModel
            {
                OrderDetails = orderDetails
            .Skip(skip)
            .Take(take)
            .OrderByDescending(od => od.OrderDetailId).ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount,
                TotalPayment = orderDetails.Select(od => od.Order.TotalPrice).Sum()
            };
        }

        #endregion

        #region MyRegion

        public SearchOrderViewModel AdvanceSearchCourseAndTeacher(DateTime startDate, DateTime endDate, int teacherId, int courseId, int pageNumber = 1, int pageSize = 16)
        {
            IQueryable<OrderDetail> orderDetails = _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .ThenInclude(o => o.OrderDetails)
                .Where(c => c.Course.TeacherId == teacherId && c.CourseId == courseId && c.Order.IsFinally == true);

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int orderDetailsCount = orderDetails.Count();
            int pagesCount = (int)Math.Ceiling(decimal.Divide(orderDetailsCount, take));

            if (startDate != null)
            {
                orderDetails = orderDetails.Where(od => od.Order.CreateDate >= startDate);
            }

            if (endDate != null)
            {
                orderDetails = orderDetails.Where(o => o.Order.CreateDate <= endDate);
            }

            return new SearchOrderViewModel
            {
                OrderDetails = orderDetails
            .Skip(skip)
            .Take(take)
            .OrderByDescending(od => od.OrderDetailId).ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount,
                TotalPayment = orderDetails.Select(od => od.Order.TotalPrice).Sum()
            };
        }

        #endregion

        #region JoinPaymentsAndOrderDetails
        public OrderDetailPaymentPagingViewModel SearchOrderDetailPayments(DateTime startDate, DateTime endDate, int teacherId, int pageNumber = 1, int pageSize = 32)
        {
            var orderDetailPayments = (from orderDetail in _db.OrderDetails.Include(o => o.Order).Include(o => o.Course)
                                       where orderDetail.Course.TeacherId == teacherId && orderDetail.Order.IsFinally == true
                                       select new OrderDetailPaymentViewModel()
                                       {
                                           Title = orderDetail.Course.Title,
                                           Price = orderDetail.Price,
                                           Payment = 0,
                                           CreateDate = orderDetail.Order.CreateDate,
                                           TeacherPercent = orderDetail.TeacherPercent.Value,
                                           IsPayment = false,
                                           TeacherId = orderDetail.Course.TeacherId,
                                           OrderTotalPrice = orderDetail.Order.TotalPrice,
                                           OrderFinally = orderDetail.Order.IsFinally
                                       }).Union(from payment in _db.Payments
                                                where payment.TeacherId == teacherId
                                                select new OrderDetailPaymentViewModel()
                                                {
                                                    Title = payment.Description,
                                                    Price = 0,
                                                    Payment = payment.Amount,
                                                    CreateDate = payment.PaymentDate,
                                                    TeacherPercent = 0,
                                                    IsPayment = true,
                                                    TeacherId = payment.TeacherId,
                                                    OrderTotalPrice = 0,
                                                    OrderFinally = false
                                                });

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int orderDetailsCount = orderDetailPayments.Count();
            int pagesCount = (int)Math.Ceiling(decimal.Divide(orderDetailsCount, take));

            if (startDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(od => od.CreateDate >= startDate);
            }

            if (endDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(o => o.CreateDate <= endDate);
            }

            return new OrderDetailPaymentPagingViewModel
            {
                OrderDetailPayments = orderDetailPayments
            .Skip(skip)
            .Take(take)
            .OrderBy(od => od.CreateDate).ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount,
                TotalOrderDetailsPayments = _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .Where(od => od.Course.TeacherId == teacherId && od.Order.IsFinally == true)
                .Select(od => od.Order.TotalPrice)
                .Sum()
            };
        }
        #endregion

        #region SearchCashDesk
        public OrderDetailPaymentPagingViewModel SearchCashDesk(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 32)
        {
            var orderDetailPayments = (from orderDetail in _db.OrderDetails.Include(od => od.Course).Include(od => od.Order)
                                       where orderDetail.Order.IsFinally == true
                                       select new OrderDetailPaymentViewModel()
                                       {
                                           Title = orderDetail.Course.Title,
                                           Price = orderDetail.Price,
                                           Payment = 0,
                                           CreateDate = orderDetail.Order.CreateDate,
                                           TeacherPercent = orderDetail.TeacherPercent.Value,
                                           IsPayment = false,
                                           TeacherId = orderDetail.Course.TeacherId,
                                           OrderTotalPrice = orderDetail.Order.TotalPrice,
                                           OrderFinally = orderDetail.Order.IsFinally
                                       })
                                       .Union(from payment in _db.Payments
                                              where payment.TeacherId == 1
                                              select new OrderDetailPaymentViewModel()
                                              {
                                                  Title = payment.Description,
                                                  Price = 0,
                                                  Payment = payment.Amount,
                                                  CreateDate = payment.PaymentDate,
                                                  TeacherPercent = 0,
                                                  IsPayment = true,
                                                  TeacherId = 1,
                                                  OrderTotalPrice = 0,
                                                  OrderFinally = false
                                              });

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int orderDetailsCount = orderDetailPayments.Count();
            int pagesCount = (int)Math.Ceiling(decimal.Divide(orderDetailsCount, take));

            if (startDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(od => od.CreateDate >= startDate);
            }

            if (endDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(o => o.CreateDate <= endDate);
            }

            return new OrderDetailPaymentPagingViewModel
            {
                OrderDetailPayments = orderDetailPayments
            .Skip(skip)
            .Take(take)
            .OrderBy(od => od.CreateDate)
            .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region SearchBox
        public OrderDetailPaymentPagingViewModel SearchBox(DateTime startDate,
            DateTime endDate,
            int pageNumber = 1,
            int pageSize = 32)
        {
            var orderDetailPayments = (from orderDetail in _db.OrderDetails
                                       select new OrderDetailPaymentViewModel()
                                       {
                                           Title = orderDetail.Course.Title,
                                           Price = orderDetail.Price,
                                           Payment = 0,
                                           CreateDate = orderDetail.Order.CreateDate,
                                           TeacherPercent = orderDetail.TeacherPercent.Value,
                                           IsPayment = false,
                                           TeacherId = orderDetail.Course.TeacherId,
                                           OrderTotalPrice = orderDetail.Order.TotalPrice,
                                           OrderFinally = orderDetail.Order.IsFinally
                                       })
                                       .Union(from payment in _db.Payments
                                              select new OrderDetailPaymentViewModel()
                                              {
                                                  Title = payment.Description,
                                                  Price = 0,
                                                  Payment = payment.Amount,
                                                  CreateDate = payment.PaymentDate,
                                                  TeacherPercent = 0,
                                                  IsPayment = true,
                                                  TeacherId = payment.TeacherId,
                                                  OrderTotalPrice = 0,
                                                  OrderFinally = true
                                              })
                                       .Where(od => od.OrderFinally == true);

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int orderDetailsCount = orderDetailPayments.Count();
            int pagesCount = (int)Math.Ceiling(decimal.Divide(orderDetailsCount, take));

            if (startDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(od => od.CreateDate >= startDate);
            }

            if (endDate != null)
            {
                orderDetailPayments = orderDetailPayments.Where(o => o.CreateDate <= endDate);
            }

            return new OrderDetailPaymentPagingViewModel
            {
                OrderDetailPayments = orderDetailPayments
            .Skip(skip)
            .Take(take)
            .OrderBy(od => od.CreateDate).ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount,
                TotalOrderDetailsPayments = _db.OrderDetails
                .Include(od => od.Course)
                .Include(od => od.Order)
                .Where(od => od.Order.IsFinally == true)
                .Select(od => od.Order.TotalPrice)
                .Sum()
            };
        }
        #endregion

        #region SearchCourse
        public CourseViewModel SearchCourses(string title, int pageId)
        {
            IQueryable<Course> courses = _db.Courses;

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                 .Where(c => c.Title.Contains(title))
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToList()
            };
        }

        public async Task<CourseViewModel> SearchCoursesAsync(string title, int pageId)
        {
            IQueryable<Course> courses = _db.Courses;

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = await courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                 .Where(c => c.Title.Contains(title))
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToListAsync()
            };
        }
        #endregion

        #region SearchCoursesAsync
        public CourseViewModel SearchUncheckedCourses(string title, int pageId)
        {
            IQueryable<Course> courses = _db.Courses.Where(c => c.IsCheckedByAdmin == false);

            // pagination logic
            int recordsPerPages = 20;
            int skip = (pageId - 1) * recordsPerPages;

            int coursesCount = courses.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(coursesCount, recordsPerPages));

            return new CourseViewModel()
            {
                CurrentPage = pageId,
                PageCount = pagesCount,
                Courses = courses
                .Include(c => c.User)
                .Include(c => c.CourseEpisodes)
                .Skip(skip)
                .Take(recordsPerPages)
                 .OrderByDescending(u => u.CourseId)
                 .Where(c => c.Title.Contains(title))
                .Select(c => new CourseDetailsViewModel
                {
                    CourseId = c.CourseId,
                    TeacherId = c.TeacherId,
                    Title = c.Title,
                    Teacher = c.User.UserName,
                    ImageName = c.ImageName,
                    EpisodesCount = c.CourseEpisodes.Count
                })
                .AsNoTracking()
                .ToList()
            };
        }
        #endregion

        /// <summary>
        /// Get course by id
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region GetCourseById
        public Course GetCourseById(int courseId)
        {
            return _db.Courses.Include(c => c.User)
                .Include(c => c.UserCourses)
                .SingleOrDefault(c => c.CourseId == courseId);
        }

        public async Task<Course> GetCourseByIdAsync(int courseId)
        {
            return await _db.Courses
                .Include(c => c.User)
                .Include(c => c.UserCourses)
                .Include(c => c.CourseInCourseTypes)
                .SingleOrDefaultAsync(c => c.CourseId == courseId);
        }
        #endregion

        /// <summary>
        /// Update course
        /// </summary>
        /// <param name="course"></param>
        /// <param name="imageCourse"></param>
        /// <param name="demoCourse"></param>
        /// <returns></returns>
        #region UpdateCourse
        public bool UpdateCourse(Course course, IFormFile imageCourse,
            IFormFile demoCourse,
            List<int> courseTypes)
        {
            try
            {
                // db success
                course.UpdateDate = DateTime.Now;

                course.ImageName = EditAndUplaodImage(course, imageCourse);

                course.Demo = EditAndUplaodDemo(course, demoCourse);

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

        public async Task<bool> UpdateCourseAsync(Course course, IFormFile imageCourse, IFormFile demoCourse,
            List<int> courseTypes)
        {
            try
            {
                // db success
                course.UpdateDate = DateTime.Now;

                if (imageCourse != null)
                {
                    course.ImageName = EditAndUplaodImage(course, imageCourse);
                }

                if (demoCourse != null)
                {
                    course.Demo = EditAndUplaodDemo(course, demoCourse);
                }

                if (courseTypes != null)
                {
                    EditCourseTypeInCourse(course.CourseId, courseTypes);
                }

                if (course.Off)
                {
                    course.PriceAfterOff = (int)(course.Price - ((course.Price * course.OffPercent) / 100));
                }

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
        /// Get courses item list
        /// </summary>
        /// <returns></returns>
        #region GetCoursesItemList
        public List<SelectListItem> GetCoursesItemList()
        {
            return _db.Courses
                .Include(c => c.User)
                .Include(c => c.CourseId)
                .Select(c => new SelectListItem
                {
                    Text = c.Title + " - " + c.User.UserName,
                    Value = c.CourseId.ToString()
                }).ToList();
        }

        public async Task<List<SelectListItem>> GetCoursesItemListAsync()
        {
            return await _db.Courses
                .Include(c => c.User)
                .Include(c => c.CourseId)
                .Select(c => new SelectListItem
                {
                    Text = c.Title + " - " + c.User.UserName,
                    Value = c.CourseId.ToString()
                }).ToListAsync();
        }
        #endregion

        #region GetCoursesItemList
        public List<SelectListItem> GetCoursesItemList2()
        {
            return _db.Courses
                .Include(c => c.User)
                .Include(c => c.CourseId)
                .Select(c => new SelectListItem
                {
                    Text = c.Title + " - " + c.User.FirstName + " " + c.User.LastName,
                    Value = c.CourseId.ToString()
                }).ToList();
        }

        public async Task<List<SelectListItem>> GetCoursesItemListAsync2()
        {
            return await _db.Courses
                .Include(c => c.User)
                .Include(c => c.CourseId)
                .Select(c => new SelectListItem
                {
                    Text = c.Title + " - " + c.User.FirstName + " " + c.User.LastName,
                    Value = c.CourseId.ToString()
                }).ToListAsync();
        }
        #endregion

        /// <summary>
        /// Add episode to course
        /// </summary>
        /// <param name="episode"></param>
        /// <returns></returns>
        #region AddEpisode
        public int AddEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            try
            {
                // db success
                episode.EpisodeFileName = AddAndUplaodTutorial(episode.EpisodeFileName, episodeFile);

                _db.CourseEpisodes.Add(episode);
                Save();

                return episode.CourseEpisodeId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        public async Task<int> AddEpisodeAsync(CourseEpisode episode, IFormFile episodeFile)
        {
            try
            {
                // db success
                episode.EpisodeFileName = AddAndUplaodTutorial(episode.EpisodeFileName, episodeFile);

                await _db.CourseEpisodes.AddAsync(episode);
                await SaveAsync();

                return episode.CourseEpisodeId;
            }
            catch
            {
                // db failure
                return -1;
            }
        }
        #endregion

        /// <summary>
        /// Check file existance
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        #region CheckFileExistnace
        public bool CheckFileExistance(string fileName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles/" + fileName);
            return File.Exists(filePath);
        }
        #endregion

        /// <summary>
        /// Get episodes of a course
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region GetEpisodes
        public List<CourseEpisode> GetEpisodes(int courseId)
        {
            return _db.CourseEpisodes
                .Include(ce => ce.Course)
                .OrderByDescending(ce => ce.CourseEpisodeId)
                .Where(ce => ce.CourseId == courseId)
                .AsNoTracking()
                .ToList();
        }

        public async Task<List<CourseEpisode>> GetEpisodesAsync(int courseId)
        {
            return await _db.CourseEpisodes
                .Include(ce => ce.Course)
                .OrderByDescending(ce => ce.CourseEpisodeId)
                .Where(ce => ce.CourseId == courseId)
                .AsNoTracking()
                .ToListAsync();
        }
        #endregion

        /// <summary>
        /// Get episode by id
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        #region GetEpisodeById
        public CourseEpisode GetEpisodeById(int episodeId)
        {
            return _db.CourseEpisodes
                .SingleOrDefault(ce => ce.CourseEpisodeId == episodeId);
        }

        public async Task<CourseEpisode> GetEpisodeByIdAsync(int episodeId)
        {
            return await _db.CourseEpisodes
                .SingleOrDefaultAsync(ce => ce.CourseEpisodeId == episodeId);
        }
        #endregion

        /// <summary>
        /// Update episode
        /// </summary>
        /// <param name="courseEpisode"></param>
        /// <param name="episodeFile"></param>
        /// <returns></returns>
        #region UpdateEpisode
        public bool UpdateEpisode(CourseEpisode courseEpisode, IFormFile episodeFile)
        {
            try
            {
                // db success
                courseEpisode.EpisodeFileName = EditAndUplaodTutorial(courseEpisode, episodeFile);

                _db.CourseEpisodes.Update(courseEpisode);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> UpdateEpisodeAsync(CourseEpisode courseEpisode, IFormFile episodeFile)
        {
            try
            {
                // db success
                courseEpisode.EpisodeFileName = EditAndUplaodTutorial(courseEpisode, episodeFile);

                _db.CourseEpisodes.Update(courseEpisode);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db success
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Delete episode
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        #region RemoveEpisode
        public bool RemoveEpisode(int episodeId)
        {
            try
            {
                // db success
                var episode = GetEpisodeById(episodeId);

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles/", episode.EpisodeFileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                _db.CourseEpisodes.Remove(episode);
                Save();

                return true;
            }
            catch
            {
                // db error
                return false;
            }
        }

        public async Task<bool> RemoveEpisodeAsync(int episodeId)
        {
            try
            {
                // db success
                var episode = await GetEpisodeByIdAsync(episodeId);

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/coursefiles/", episode.EpisodeFileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                _db.CourseEpisodes.Remove(episode);
                await SaveAsync();

                return true;
            }
            catch
            {
                // db error
                return false;
            }
        }
        #endregion

        /// <summary>
        /// Filter and order courses by many parameters
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="filter"></param>
        /// <param name="type"></param>
        /// <param name="orderBy"></param>
        /// <param name="startPrice"></param>
        /// <param name="endPrice"></param>
        /// <param name="selectedGroups"></param>
        /// <returns></returns>
        #region GetCourses
        public Tuple<List<DisplayCourseViewModel>, int> GetCourses(int pageId = 1,
            string filter = "",
            string type = "all",
            string orderBy = "date",
            int startPrice = 0,
            int endPrice = 0,
            List<int> selectedGroups = null, int take = 12)
        {
            IQueryable<Course> result = _db.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                // search
                result = result.Where(c => c.Title.Contains(filter) || c.Tags.Contains(filter));
            }

            // type: forSale - free
            switch (type)
            {
                case "forSale":
                    result = result.Where(c => c.Price > 0);
                    break;
                case "free":
                    result = result.Where(c => c.Price == 0);
                    break;
                case "all":
                default:
                    break;
            }

            // order: old - latest
            switch (orderBy)
            {
                case "date":
                    result = result.OrderBy(c => c.CreateDate);
                    break;
                case "latestDate":
                    result = result.OrderByDescending(c => c.CreateDate);
                    break;
                default:
                    break;
            }

            // filter by price
            if (startPrice > 0)
            {
                result = result.Where(c => c.Price > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.Price < endPrice);
            }

            // filter by groups and subgroups
            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (var groupId in selectedGroups)
                {
                    result = result.Where(c => selectedGroups.Contains(c.GroupId) || selectedGroups.Contains((int)c.SubGroupId));
                }
            }

            // pagination logic
            int skip = (pageId - 1) * take;

            int pageCount = (int)Math.Ceiling(decimal.Divide(result.Count(), take));

            return Tuple.Create(result.Include(c => c.Group).Include(c => c.CourseEpisodes)
                .OrderByDescending(c => c.CourseId)
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    ImageName = c.ImageName,
                    GroupName = c.Group.Title,
                    Price = c.Price,
                    Title = c.Title,
                    Off = c.Off,
                    OffPercentage = c.OffPercent,
                    PriceAfterOff = c.PriceAfterOff,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                })
                .Skip(skip).Take(take)
                .AsNoTracking().ToList(), pageCount);
        }

        public async Task<Tuple<List<DisplayCourseViewModel>, int>> GetCoursesAsync(int pageId = 1,
            string filter = "",
            string type = "all",
            string orderBy = "date",
            int startPrice = 0,
            int endPrice = 0,
            List<int> selectedGroups = null, int take = 12)
        {
            IQueryable<Course> result = _db.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                // search
                result = result.Where(c => c.Title.Contains(filter) || c.Tags.Contains(filter));
            }

            // type: forSale - free
            switch (type)
            {
                case "forSale":
                    result = result.Where(c => c.Price > 0);
                    break;
                case "free":
                    result = result.Where(c => c.Price == 0);
                    break;
                case "all":
                default:
                    break;
            }

            // order: old - latest
            switch (orderBy)
            {
                case "date":
                    result = result.OrderBy(c => c.CreateDate);
                    break;
                case "latestDate":
                    result = result.OrderByDescending(c => c.CreateDate);
                    break;
                default:
                    break;
            }

            // filter by groups and subgroups
            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (var groupId in selectedGroups)
                {
                    result = result.Where(c => selectedGroups.Contains(c.GroupId) || selectedGroups.Contains((int)c.SubGroupId));
                }
            }

            // filter by price
            if (startPrice > 0)
            {
                result = result.Where(c => c.Price > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.Price < endPrice);
            }

            // pagination logic
            int skip = (pageId - 1) * take;

            int pageCount = (int)Math.Ceiling(decimal.Divide(result.Count(), take));

            return Tuple.Create(await result.Include(c => c.Group).Include(c => c.CourseEpisodes)
                .OrderByDescending(c => c.CourseId)
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    ImageName = c.ImageName,
                    Price = c.Price,
                    Title = c.Title,
                    Off = c.Off,
                    OffPercentage = c.OffPercent,
                    PriceAfterOff = c.PriceAfterOff,
                    GroupName = c.Group.Title,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                }).Skip(skip).Take(take).AsNoTracking().ToListAsync(), pageCount);
        }
        #endregion

        /// <summary>
        /// Get course to display for the user
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        #region GetCourse
        public Course GetCourse(int courseId)
        {
            return _db.Courses
                .Where(c => c.IsCheckedByAdmin == true)
                .Include(c => c.Group)
                .Include(c => c.CourseEpisodes)
                .Include(c => c.CourseLevel)
                .Include(c => c.CourseStatus)
                .Include(c => c.User)
                .Include(c => c.UserCourses)
                .SingleOrDefault(c => c.CourseId == courseId);
        }

        public async Task<Course> GetCourseAsync(int courseId)
        {
            return await _db.Courses
                .Where(c => c.IsCheckedByAdmin == true)
                .Include(c => c.Group)
                .Include(c => c.CourseEpisodes)
                .Include(c => c.CourseLevel)
                .Include(c => c.CourseStatus)
                .Include(c => c.User)
                .Include(c => c.UserCourses)
                .SingleOrDefaultAsync(c => c.CourseId == courseId);
        }
        #endregion

        /// <summary>
        /// Get latest course
        /// </summary>
        /// <returns></returns>
        #region LatestCourses
        public List<DisplayCourseViewModel> GetLatestCourse()
        {
            return _db.Courses
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true)
                .OrderByDescending(c => c.CourseId)
                .Take(9)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    ImageName = c.ImageName,
                    Price = c.Price,
                    Title = c.Title,
                    Off = c.Off,
                    OffPercentage = c.OffPercent,
                    PriceAfterOff = c.PriceAfterOff,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                }).AsNoTracking().ToList();
        }

        public async Task<List<DisplayCourseViewModel>> GetLatestCourseAsync()
        {
            return await _db.Courses
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true)
                 .OrderByDescending(c => c.CourseId)
                 .Take(9)
                 .Select(c => new DisplayCourseViewModel
                 {
                     CourseId = c.CourseId,
                     ImageName = c.ImageName,
                     Price = c.Price,
                     Title = c.Title,
                     Off = c.Off,
                     OffPercentage = c.OffPercent,
                     PriceAfterOff = c.PriceAfterOff,
                     TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                 }).AsNoTracking().ToListAsync();
        }
        #endregion

        /// <summary>
        /// Get latest course
        /// </summary>
        /// <returns></returns>
        #region RelatedCourses
        public List<DisplayCourseViewModel> GetRelatedCourses(int groupId)
        {
            return _db.Courses
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true && c.GroupId == groupId)
                .Take(8)
                .OrderByDescending(c => c.CourseId)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    ImageName = c.ImageName,
                    Price = c.Price,
                    Title = c.Title,
                    Off = c.Off,
                    OffPercentage = c.OffPercent,
                    PriceAfterOff = c.PriceAfterOff,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                }).AsNoTracking().ToList();
        }

        public async Task<List<DisplayCourseViewModel>> GetRelatedCoursesAsync(int groupId)
        {
            return await _db.Courses
                .Where(c => c.IsHidden == false && c.IsCheckedByAdmin == true && c.GroupId == groupId)
                 .Take(8)
                 .OrderByDescending(c => c.CourseId)
                 .Select(c => new DisplayCourseViewModel
                 {
                     CourseId = c.CourseId,
                     ImageName = c.ImageName,
                     Price = c.Price,
                     Title = c.Title,
                     Off = c.Off,
                     OffPercentage = c.OffPercent,
                     PriceAfterOff = c.PriceAfterOff,
                     TotalTime = new TimeSpan(c.CourseEpisodes.Sum(ce => ce.EpisodeLength.Ticks))
                 }).AsNoTracking().ToListAsync();
        }
        #endregion

        /// <summary>
        /// Add user comment to the course
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        #region AddComment
        public bool AddComment(Comment comment)
        {
            try
            {
                // db success
                _db.Comments.Add(comment);
                Save();

                return true;
            }
            catch
            {
                // db failure
                return false;
            }
        }

        public async Task<bool> AddCommentAsync(Comment comment)
        {
            try
            {
                // db success
                await _db.Comments.AddAsync(comment);
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
        /// Display user comments
        /// </summary>
        /// <returns></returns>
        #region GetComments
        public Tuple<List<Comment>, int> GetComments(int courseId, int pageId = 1)
        {
            IQueryable<Comment> comments = _db.Comments
                .Where(c => c.CourseId == courseId && !c.IsDelete && c.ReadByAdmin == true);
            int recordsPerPage = 16;
            int skip = (pageId - 1) * recordsPerPage;

            int commentsCount = comments.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(commentsCount, recordsPerPage));

            return Tuple.Create(_db.Comments
                .Include(c => c.User)
                .Include(c => c.Course)
                .ThenInclude(co => co.User)
                .Where(c => c.CourseId == courseId && !c.IsDelete && c.ReadByAdmin == true)
                .Skip(skip)
                .Take(recordsPerPage)
                .AsNoTracking()
                .ToList(), pagesCount);
        }

        public async Task<Tuple<List<Comment>, int>> GetCommentsAsync(int courseId, int pageId = 1)
        {
            IQueryable<Comment> comments = _db.Comments
                .Where(c => c.CourseId == courseId && !c.IsDelete && c.ReadByAdmin == true);
            int recordsPerPage = 10;
            int skip = (pageId - 1) * recordsPerPage;

            int commentsCount = comments.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(commentsCount, recordsPerPage));

            return Tuple.Create(await _db.Comments
                .Include(c => c.User)
                .Include(c => c.Course)
                .ThenInclude(co => co.User)
                .Where(c => c.CourseId == courseId && !c.IsDelete)
                .AsNoTracking()
                .ToListAsync(), pagesCount);
        }
        #endregion

        #region UncheckedEpisodesCount
        public int UncheckedEpisodesCount() => _db.CourseEpisodes.Where(ce => ce.IsCheckedByAdmin == false).Count();
        #endregion

        #region GetAllCommentsToManage
        public CommentPagingViewModel GetAllCommentsToManage(int pageNumber = 1, int pageSize = 32)
        {
            IQueryable<Comment> comments = _db.Comments;

            int take = pageSize;
            int skip = (pageNumber - 1) * take;
            int commentsCount = comments.Count();

            int pagesCount = (int)Math.Ceiling(decimal.Divide(commentsCount, take));

            return new CommentPagingViewModel
            {
                Comments = comments
                .Include(c => c.Course)
                .Include(c => c.User)
                .Skip(skip)
                .Take(take)
                .OrderByDescending(c => c.ReadByAdmin == false)
                .ThenByDescending(c => c.IsDelete == false)
                .ToList(),
                PageNumber = pageNumber,
                PagesCount = pagesCount
            };
        }
        #endregion

        #region GetAlCommentsCount
        public int GetAllCommentsCount() => _db.Comments.Count();
        #endregion

        #region CommentsCount
        public int CommentsCount() => _db.Comments.Count();
        #endregion

        #region UncheckedCommentsCount
        public int UncheckedCommentsCount() => _db.Comments
            .Where(c => c.ReadByAdmin == false)
            .Count();
        #endregion

        #region GetCommentById
        public Comment GetCommentById(int commentId) => _db.Comments.Include(c => c.User)
            .SingleOrDefault(c => c.CommentId == commentId);
        #endregion

        #region UpdateComment
        public Comment UpdateComment(Comment comment)
        {
            try
            {
                _db.Comments.Update(comment);
                Save();

                return comment;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region RemoveComment
        public Comment RemoveComment(int commentId)
        {
            try
            {
                var comment = GetCommentById(commentId);

                comment.IsDelete = true;

                _db.Comments.Update(comment);
                Save();

                return comment;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        /// <summary>
        /// List of popular courses
        /// </summary>
        #region PopularCourses
        public List<DisplayCourseViewModel> GetPopularCourses()
        {
            return _db.Courses
                .Include(c => c.OrderDetails)
                .Where(c => c.OrderDetails.Any())
                .OrderByDescending(c => c.OrderDetails.Count)
                .Take(8)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Price = c.Price,
                    ImageName = c.ImageName,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeLength.Ticks))
                })
                .AsNoTracking()
                .ToList();
        }

        public async Task<List<DisplayCourseViewModel>> GetPopularCoursesAsync()
        {
            return await _db.Courses
                .Include(c => c.OrderDetails)
                .Where(c => c.OrderDetails.Any())
                .OrderByDescending(c => c.OrderDetails.Count)
                .Take(8)
                .Select(c => new DisplayCourseViewModel
                {
                    CourseId = c.CourseId,
                    Title = c.Title,
                    Price = c.Price,
                    ImageName = c.ImageName,
                    TotalTime = new TimeSpan(c.CourseEpisodes.Sum(e => e.EpisodeLength.Ticks))
                })
                .AsNoTracking()
                .ToListAsync();
        }
        #endregion

        /// <summary>
        /// Add rating system to every courses
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="courseId"></param>
        /// <param name="rate"></param>
        #region RateCourse
        public void AddRate(string userName, int courseId, byte rate)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            RateCourse rateCourse = new RateCourse()
            {
                CourseId = courseId,
                UserId = userId,
                Rate = rate
            };
            _db.RateCourses.Add(rateCourse);
            Save();
        }

        public void UpdateRate(RateCourse rateCourse)
        {
            _db.RateCourses.Update(rateCourse);
            Save();
        }

        public bool IsUserRatedTheCourse(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _db.RateCourses.Any(rc => rc.UserId == userId && rc.CourseId == courseId);
        }
        #endregion

        #region CourseCount
        public int CourseCount() => _db.Courses.Count();
        public async Task<int> CourseCountAsync() => await _db.Courses.CountAsync();
        #endregion

        #region GroupCount
        public int GroupsCount() => _db.Groups
            .Where(g => g.ParentId == null)
            .Count();
        public async Task<int> GroupsCountAsync() => await _db.Groups
            .Where(g => g.ParentId == null)
            .CountAsync();
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

        #region Helpers

        public string UploadIcon(IFormFile formFile)
        {
            if (formFile != null)
            {
                string fileName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(formFile.FileName);

                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/groups/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    formFile.CopyTo(fileStream);
                }

                return fileName;
            }
            else
            {
                return "default.svg";
            }
        }

        public string ModifiedUploadIcon(Group group, IFormFile formFile)
        {
            if (formFile != null)
            {
                if (group.ImageName != "default.svg" && group.ImageName != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/groups/", group.ImageName);

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }

                return UploadIcon(formFile);
            }
            else
            {
                return group.ImageName;
            }
        }

        /// <summary>
        /// Add and upload an image
        /// </summary>
        /// <param name="imageName"></param>
        /// <param name="ImageFile"></param>
        public string AddAndUplaodImage(string imageName, IFormFile ImageFile)
        {
            if (ImageFile != null && ImageFile.IsImage())
            {
                imageName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(ImageFile.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/courses/" + imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                // resize course image
                ImageResizer imgResizer = new ImageResizer();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/thumbnails/" + imageName);
                imgResizer.Image_resize(imagePath, thumbPath, 75);

                return imageName;
            }

            return "default.png";
        }

        /// <summary>
        /// Add and Upload demo file
        /// </summary>
        /// <param name="demoName"></param>
        /// <param name="DemoFile"></param>
        public string AddAndUplaodDemo(string demoName, IFormFile DemoFile)
        {
            if (DemoFile != null)
            {
                demoName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(DemoFile.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/demos/" + demoName);

                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    DemoFile.CopyTo(stream);
                }

                return demoName;
            }

            return null;
        }

        /// <summary>
        /// Add and Upload tutorial file
        /// </summary>
        /// <param name="demoName"></param>
        /// <param name="DemoFile"></param>
        public string AddAndUplaodTutorial(string episodeName, IFormFile episodeFile)
        {
            episodeName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(episodeFile.FileName);
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/coursefiles/" + episodeName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                episodeFile.CopyTo(stream);
            }

            return episodeName;
        }

        /// <summary>
        /// Add and upload an image
        /// </summary>
        /// <param name="imageName"></param>
        /// <param name="ImageFile"></param>
        public string EditAndUplaodImage(Course course, IFormFile ImageFile)
        {

            if (ImageFile != null && ImageFile.IsImage())
            {

                if (course.ImageName.TextTransform() != "default.png")
                {
                    // course old image

                    // fullsize
                    string fullSizePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/courses/", course.ImageName);
                    if (File.Exists(fullSizePath))
                    {
                        File.Delete(fullSizePath);
                    }

                    // thumbnail
                    string thumbnailPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/thumbnails/", course.ImageName);
                    if (File.Exists(thumbnailPath))
                    {
                        File.Delete(thumbnailPath);
                    }
                }

                string imageName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(ImageFile.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/courses/" + imageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImageFile.CopyTo(stream);
                }

                // resize course image
                ImageResizer imgResizer = new ImageResizer();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/thumbnails/" + imageName);
                imgResizer.Image_resize(imagePath, thumbPath, 75);

                return imageName;
            }

            return course.ImageName;
        }

        /// <summary>
        /// Add and Upload demo file
        /// </summary>
        /// <param name="demoName"></param>
        /// <param name="DemoFile"></param>
        public string EditAndUplaodDemo(Course course, IFormFile DemoFile)
        {

            if (DemoFile != null)
            {
                // user select new image

                if (course.Demo != null)
                {
                    // course old image
                    string oldDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/demos/", course.Demo);

                    if (File.Exists(oldDemoPath))
                    {
                        File.Delete(oldDemoPath);
                    }
                }

                string demoName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(DemoFile.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/demos/" + demoName);

                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    DemoFile.CopyTo(stream);
                }

                return demoName;
            }
            else
            {
                return course.Demo;
            }
        }

        /// <summary>
        /// Add and Upload demo file
        /// </summary>
        /// <param name="episodeName"></param>
        /// <param name="episodeFile"></param>
        public string EditAndUplaodTutorial(CourseEpisode courseEpisode, IFormFile episodeFile)
        {
            if (episodeFile != null)
            {
                // old episode
                string oldEpisodePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/coursefiles/", courseEpisode.EpisodeFileName);
                if (File.Exists(oldEpisodePath))
                {
                    File.Delete(oldEpisodePath);
                }

                string episodeName = CodeGenerator.GenerateUniqueCode() + Path.GetExtension(episodeFile.FileName);
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFiles/" + episodeName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    episodeFile.CopyTo(stream);
                }

                return episodeName;
            }

            return courseEpisode.EpisodeFileName;
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

        public bool EditCourseTypeInCourse(int courseId, List<int> courseTypes)
        {
            try
            {
                _db.CourseInCoursetypes.Where(cc => cc.CourseId == courseId).ToList()
                     .ForEach(cc => _db.CourseInCoursetypes.Remove(cc));

                foreach (var courseTypeId in courseTypes)
                {
                    _db.CourseInCoursetypes.Add(new CourseInCourseType
                    {
                        CourseId = courseId,
                        CourseTypeId = courseTypeId
                    });

                    _db.SaveChanges();
                }

                return true;
            }
            catch
            {
                // TODO: log error
                return false;
            }
        }

        private void RemoveGroupImage(Group group)
        {
            if (!string.IsNullOrEmpty(group.ImageName))
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/groups", group.ImageName);

                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }

        #endregion
    }
}
