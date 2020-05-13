using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    [PermissionChecker(25)]
    public class EditUncheckedCourseModel : PageModel
    {
        private ICourseService _courseService;

        public EditUncheckedCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            return await SeedCourseInitialDataAsync(id);
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
                    return RedirectToPage("UncheckedCourses");
                }

                // failure
                ViewData["Failure"] = "متاسفانه عملیات افزودن درس توسط استاد با مشکل روبرو شد.";

                await SeedCourseInitialDataAsync(Course.CourseId);
                return Page();
            }

            // user inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";

            await SeedCourseInitialDataAsync(Course.CourseId);
            return Page();
        }

        #region Helpers
        private async Task<IActionResult> SeedCourseInitialDataAsync(int courseId)
        {

            Course = await _courseService.GetCourseByIdAsync(courseId);

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

            ViewData["SelectedCourseTypes"] = _courseService.GetCourseTypeByCourseId(courseId);

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
        #endregion
    }
}