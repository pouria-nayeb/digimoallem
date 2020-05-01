using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    //[PermissionChecker(25)]
    public class EditModel : PageModel
    {
        private ICourseService _courseService;

        public EditModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Course = await _courseService.GetCourseByIdAsync(id);

            if (Course == null)
            {
                return NotFound();
            }

            List<SelectListItem> groups = await _courseService.GetGroupsToManageCourseAsync();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text", Course.GroupId);

            List<SelectListItem> subGroups = new List<SelectListItem>() {
                new SelectListItem() { Text = "انتخاب کنید", Value = "" }
            };
            subGroups.AddRange(await _courseService.GetSubGroupsToManageCourseAsync(Course.GroupId));

            string selectedSubgroup = (Course.SubGroup != null) ? Course.SubGroup.ToString() : null;
            ViewData["SubGroups"] = new SelectList(subGroups,
                "Value",
                "Text",
                selectedSubgroup);

            ViewData["SelectedCourseTypes"] = _courseService.GetCourseTypeByCourseId(id);

            List<SelectListItem> teachers = await _courseService
                .GetTeachersAsync();
            ViewData["Teachers"] = new SelectList(teachers, "Value", "Text", Course.TeacherId);

            List<SelectListItem> courseLevels = await _courseService
                .GetCourseLevelsAsync();
            ViewData["CourseLevels"] = new SelectList(courseLevels, "Value", "Text", Course.CourseLevel);

            List<SelectListItem> courseStatus = await _courseService
                .GetCourseStatusesAsync();
            ViewData["CourseStatuses"] = new SelectList(courseStatus, "Value", "Text", Course.CourseStatusId);

            List<SelectListItem> courseTypes = await _courseService
    .GetCourseTypesAsync();
            ViewData["CourseTypes"] = new SelectList(courseTypes, "Value", "Text");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile imgCourseUpload, IFormFile demo, List<int> courseTypes)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.UpdateCourseAsync(Course, imgCourseUpload, demo, courseTypes))
                {
                    // success
                    TempData["Success"] = "درس با موفقیت ویرایش شد.";
                    return RedirectToPage("Index");
                }

                // failure
                TempData["OperationFailed"] = "متاسفانه عملیات افزودن درس توسط استاد با مشکل روبرو شد.";
                return Page();
            }

            // user inputs is not valid
            TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
            return Page();
        }
    }
}