using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.BLL.DTOs.Orders;
using DigiMoallem.DAL.Entities.Courses;
using DigiMoallem.DAL.Entities.Orders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface ICourseService : IDisposable
    {
        // groups
        #region GetGroups
        List<Group> GetGroups();
        Task<List<Group>> GetGroupsAsync();
        #endregion

        #region GetGroupsToManageCourse
        List<SelectListItem> GetGroupsToManageCourse();
        Task<List<SelectListItem>> GetGroupsToManageCourseAsync();
        #endregion

        #region GetSubGroupsToManageCourse
        List<SelectListItem> GetSubGroupsToManageCourse(int groupId);
        Task<List<SelectListItem>> GetSubGroupsToManageCourseAsync(int groupId);
        #endregion

        #region AddGroup
        bool AddGroup(Group group, IFormFile formFile);
        Task<bool> AddGroupAsync(Group group, IFormFile formFile);
        #endregion

        #region GetGroupById
        Group GetGroupById(int groupId);
        Task<Group> GetGroupByIdAsync(int groupId);
        #endregion

        #region UpdateGroup
        bool UpdateGroup(Group group, IFormFile formFile);
        Task<bool> UpdateGroupAsync(Group group, IFormFile formFile);
        #endregion

        #region DeleteGroup
        bool DeleteGroup(Group group);
        Task<bool> DeleteGroupAsync(Group group);
        #endregion

        #region Relatedcourses
        List<DisplayCourseViewModel> GetRelatedCourses(int groupId);
        Task<List<DisplayCourseViewModel>> GetRelatedCoursesAsync(int groupId);
        #endregion

        #region GetCourseTypesByCourseId
        List<int> GetCourseTypeByCourseId(int courseId);
        #endregion

        #region GetParentGroups
        Task<List<Group>> GetParentGroups();
        #endregion

        #region GetCourseTypeNameById
        string GetCourseTypeNameById(int courseTypeId);
        #endregion

        #region AdvanceSearchCourseAndTeacher
        SearchOrderViewModel AdvanceSearchCourseAndTeacher(DateTime startDate, DateTime endDate, int teacherId, int courseId, int pageNumber = 1, int pageSize = 16);
        #endregion

        #region SearchCashDesk
        OrderDetailPaymentPagingViewModel SearchCashDesk(DateTime startDate, DateTime endDate, int pageNumber = 1, int pageSize = 32);
        #endregion

        // courses
        #region GetCourseLevels
        List<SelectListItem> GetCourseLevels();
        Task<List<SelectListItem>> GetCourseLevelsAsync();
        #endregion

        #region GetCourseStatuses
        List<SelectListItem> GetCourseStatuses();
        Task<List<SelectListItem>> GetCourseStatusesAsync();
        #endregion

        #region GetCourseTypes
        List<SelectListItem> GetCourseTypes();
        Task<List<SelectListItem>> GetCourseTypesAsync();
        #endregion

        #region GetTeachers
        List<SelectListItem> GetTeachers();
        Task<List<SelectListItem>> GetTeachersAsync();
        #endregion

        #region AddCourse
        int AddCourse(Course course, IFormFile imageCourse, IFormFile demoCourse,
            List<int> courseTypes);
        Task<int> AddCourseAsync(Course course, IFormFile imageCourse, IFormFile demoCourse,
            List<int> courseTypes);
        #endregion

        #region GetCoursesForAdmin
        CourseViewModel GetCoursesForAdmin(int pageId = 1);
        Task<CourseViewModel> GetCoursesForAdminAsync(int pageId = 1);
        #endregion

        #region SearchCourses
        CourseViewModel SearchCourses(string title, int pageId);
        Task<CourseViewModel> SearchCoursesAsync(string title, int pageId);
        #endregion

        #region GetCourseById
        Course GetCourseById(int courseId);
        Task<Course> GetCourseByIdAsync(int courseId);
        #endregion

        #region UpdateCourse
        bool UpdateCourse(Course course, IFormFile imageCourse, IFormFile demoCourse, List<int> courseTypes);
        Task<bool> UpdateCourseAsync(Course course, IFormFile imageCourse, IFormFile demoCourse, List<int> courseTypes);
        #endregion

        #region CoursesCount
        int CoursesCount();
        Task<int> CoursesCountAsync();
        #endregion

        #region GetCoursesItemList
        List<SelectListItem> GetCoursesItemList();
        Task<List<SelectListItem>> GetCoursesItemListAsync();
        #endregion

        #region GetCoursesItemList2
        List<SelectListItem> GetCoursesItemList2();
        Task<List<SelectListItem>> GetCoursesItemListAsync2();
        #endregion

        #region PopularCourses
        List<DisplayCourseViewModel> GetPopularCourses();
        Task<List<DisplayCourseViewModel>> GetPopularCoursesAsync();
        #endregion

        #region LatestCourses
        List<DisplayCourseViewModel> GetLatestCourse();
        Task<List<DisplayCourseViewModel>> GetLatestCourseAsync();
        #endregion

        #region AdvanceSearchCourse
        SearchOrderViewModel AdvanceSearchCourse(DateTime startDate, DateTime endDate, int teacherId, int pageNumber = 1, int pageSize = 16);
        #endregion

        #region TeacherTotalIncome
        int TeacherTotalIncome(int teacherId);
        Task<int> TeacherTotalIncomeAsync(int teacherId);
        #endregion

        #region IsFavoriteCourses
        List<DisplayCourseViewModel> LatestFavoriteCourses();
        #endregion

        #region GetUsersEmail
        List<string> GetUsersEmail();
        #endregion

        #region GetTeacherCoursesForAdminAsync
        CourseViewModel GetTeacherCoursesForAdminAsync(int pageId, int teacherId);
        #endregion

        #region GetUncheckedCoursesForAdmin
        CourseViewModel GetUncheckedCoursesForAdmin(int pageId);
        #endregion

        #region GetCoursesOfTeacher
        CourseViewModel GetCoursesOfTeacher(int teacherId, int pageNumber = 1, int pageSize = 16);
        #endregion

        #region SearchUncheckedCourses
        CourseViewModel SearchUncheckedCourses(string title, int pageId);
        #endregion

        #region SearchOrderDetailPayments
        OrderDetailPaymentPagingViewModel SearchOrderDetailPayments(DateTime startDate, DateTime endDate, int teacherId, int pageNumber = 1, int pageSize = 32);
        #endregion

        #region SearchBox
        OrderDetailPaymentPagingViewModel SearchBox(DateTime startDate,
            DateTime endDate,
            int pageNumber = 1,
            int pageSize = 32);
        #endregion

        // episodes
        #region AddEpisode
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        Task<int> AddEpisodeAsync(CourseEpisode episode, IFormFile episodeFile);
        #endregion

        #region CheckFileExistnace
        bool CheckFileExistance(string fileName);
        #endregion

        #region GetEpisodes
        List<CourseEpisode> GetEpisodes(int courseId);
        Task<List<CourseEpisode>> GetEpisodesAsync(int courseId);
        #endregion

        #region GetEpisodeById
        CourseEpisode GetEpisodeById(int episodeId);
        Task<CourseEpisode> GetEpisodeByIdAsync(int episodeId);
        #endregion

        #region UpdateEpisode
        bool UpdateEpisode(CourseEpisode courseEpisode, IFormFile episodeFile);
        Task<bool> UpdateEpisodeAsync(CourseEpisode courseEpisode, IFormFile episodeFile);
        #endregion

        #region RemoveEpisode
        bool RemoveEpisode(int episodeId);
        Task<bool> RemoveEpisodeAsync(int episodeId);
        #endregion

        #region GetAllUncheckedEpisodes
        CourseEpisodesViewModel GetAllUncheckedEpisodes(int pageNumber = 1, int pageSize = 32);
        #endregion

        #region UncheckedEpisodesCount
        int UncheckedEpisodesCount();
        #endregion

        // Display courses
        #region GetCourses
        Tuple<List<DisplayCourseViewModel>, int> GetCourses(int pageId = 1,
            string filter="", 
            string type="all",
            string orderBy="date",
            int startPrice=0,
            int endPrice = 0,
            List<int> selectedGroups = null, int take = 20);

        Task<Tuple<List<DisplayCourseViewModel>, int>> GetCoursesAsync(int pageId = 1,
            string filter = "",
            string type = "all",
            string orderBy = "date",
            int startPrice = 0,
            int endPrice = 0,
            List<int> selectedGroups = null, int take=20);
        #endregion

        #region GetCourse
        Course GetCourse(int courseId);
        Task<Course> GetCourseAsync(int courseId);
        #endregion

        #region UncheckedCoursesCount
        int UncheckedCoursesCount();
        #endregion

        List<string> GetCourseTitles();

        // Comments
        #region AddComment
        bool AddComment(Comment comment);
        Task<bool> AddCommentAsync(Comment comment);
        #endregion

        #region GetComments
        Tuple<List<Comment>, int> GetComments(int courseId, int pageId = 1);
        Task<Tuple<List<Comment>, int>> GetCommentsAsync(int courseId, int pageId = 1);
        #endregion

        #region GetCommentById
        Comment GetCommentById(int commentId);
        #endregion

        #region UpdateComment
        Comment UpdateComment(Comment comment);
        #endregion

        #region GetAllCommentsToManage
        CommentPagingViewModel GetAllCommentsToManage(int pageNumber = 1, int pageSize = 32);
        #endregion

        #region UncheckedCommentsCount
        int UncheckedCommentsCount();
        #endregion

        #region CommentsCount
        int CommentsCount();
        #endregion

        #region RemoveComment
        Comment RemoveComment(int commentId);
        #endregion

        // rate course
        #region RateCourse
        void AddRate(string userName,int courseId, byte rate);
        void UpdateRate(RateCourse rateCourse);
        bool IsUserRatedTheCourse(string userName, int courseId);
        #endregion

        #region CourseCount
        int CourseCount();
        Task<int> CourseCountAsync();
        #endregion

        #region GroupCount
        int GroupsCount();
        Task<int> GroupsCountAsync();
        #endregion

        #region Save
        void Save();
        Task SaveAsync();
        #endregion
    }
}