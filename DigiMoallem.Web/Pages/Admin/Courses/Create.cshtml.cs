using DigiMoallem.BLL.Helpers.Security;
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
    [PermissionChecker(1007)]
    public class CreateModel : PageModel
    {
        private ICourseService _courseService;

        public CreateModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task OnGetAsync()
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
        }

        public async Task<IActionResult> OnPostAsync(IFormFile imgCourseUpload, IFormFile demo)
        {
            if (ModelState.IsValid)
            {
                // user inputs is valid

                if (await _courseService.AddCourseAsync(Course, imgCourseUpload, demo) > 0)
                {
                    // success
                    TempData["Success"] = "درس با موفقیت افزوده شد.";
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