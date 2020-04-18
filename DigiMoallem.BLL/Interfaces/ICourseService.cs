﻿using DigiMoallem.BLL.DTOs.Admin.Courses;
using DigiMoallem.BLL.DTOs.Courses;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Interfaces
{
    public interface ICourseService
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


        // courses
        #region GetCourseLevels
        List<SelectListItem> GetCourseLevels();
        Task<List<SelectListItem>> GetCourseLevelsAsync();
        #endregion

        #region GetCourseStatuses
        List<SelectListItem> GetCourseStatuses();
        Task<List<SelectListItem>> GetCourseStatusesAsync();
        #endregion

        #region GetTeachers
        List<SelectListItem> GetTeachers();
        Task<List<SelectListItem>> GetTeachersAsync();
        #endregion

        #region AddCourse
        int AddCourse(Course course, IFormFile imageCourse, IFormFile demoCourse);
        Task<int> AddCourseAsync(Course course, IFormFile imageCourse, IFormFile demoCourse);
        #endregion

        #region GetCoursesForAdmin
        CourseViewModel GetCoursesForAdmin(int pageId = 1);
        Task<CourseViewModel> GetCoursesForAdminAsync(int pageId = 1);
        #endregion

        #region GetCourseById
        Course GetCourseById(int courseId);
        Task<Course> GetCourseByIdAsync(int courseId);
        #endregion

        #region UpdateCourse
        bool UpdateCourse(Course course, IFormFile imageCourse, IFormFile demoCourse);
        Task<bool> UpdateCourseAsync(Course course, IFormFile imageCourse, IFormFile demoCourse);
        #endregion

        #region GetCoursesItemList
        List<SelectListItem> GetCoursesItemList();
        Task<List<SelectListItem>> GetCoursesItemListAsync();
        #endregion

        #region PopularCourses
        List<DisplayCourseViewModel> GetPopularCourses();
        Task<List<DisplayCourseViewModel>> GetPopularCoursesAsync();
        #endregion

        #region LatestCourses
        List<DisplayCourseViewModel> GetLatestCourse();
        Task<List<DisplayCourseViewModel>> GetLatestCourseAsync();
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

        // Comments
        #region AddComment
        bool AddComment(Comment comment);
        Task<bool> AddCommentAsync(Comment comment);
        #endregion

        #region GetComments
        Tuple<List<Comment>, int> GetComments(int courseId, int pageId = 1);
        Task<Tuple<List<Comment>, int>> GetCommentsAsync(int courseId, int pageId = 1);
        #endregion

        #region CourseIncomeCalculator
        void CourseIncomeCalculator(int courseId);
        Task CourseIncomeCalculatorAsync(int courseId);
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