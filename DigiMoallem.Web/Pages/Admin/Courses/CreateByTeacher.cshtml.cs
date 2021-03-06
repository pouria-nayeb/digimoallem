﻿using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(24)]
    public class CreateByTeacherModel : PageModel
    {
        private ICourseService _courseService;

        public CreateByTeacherModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task OnGetAsync()
        {
            await FeedInitialCourseDataAsync();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile imgCourseUpload, IFormFile demo, List<int> courseTypes)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.AddCourseAsync(Course, imgCourseUpload, demo, courseTypes) > 0)
                {
                    // success
                    TempData["Success"] = "درس با موفقیت افزوده شد.";
                    return RedirectToPage("Teacher");
                }

                // failure
                ViewData["Failure"] = "متاسفانه عملیات افزودن درس توسط استاد با مشکل روبرو شد.";

                await FeedInitialCourseDataAsync();
                return Page();
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";

            await FeedInitialCourseDataAsync();
            return Page();
        }

        #region Helpers
        public async Task FeedInitialCourseDataAsync()
        {
            List<SelectListItem> groups = await _courseService.GetGroupsToManageCourseAsync();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            List<SelectListItem> subGroups = await _courseService
                .GetSubGroupsToManageCourseAsync(int.Parse(groups.First().Value));
            ViewData["SubGroups"] = new SelectList(subGroups, "Value", "Text");

            List<SelectListItem> teachers = await _courseService
                .GetTeachersAsync();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text");

            List<SelectListItem> courseLevels = await _courseService
                .GetCourseLevelsAsync();
            ViewData["CourseLevels"] = new SelectList(courseLevels, "Value", "Text");

            List<SelectListItem> courseStatus = await _courseService
                .GetCourseStatusesAsync();
            ViewData["CourseStatuses"] = new SelectList(courseStatus, "Value", "Text");

            List<SelectListItem> courseTypes = await _courseService
                .GetCourseTypesAsync();
            ViewData["CourseTypes"] = new SelectList(courseTypes, "Value", "Text");
        }
        #endregion
    }
}