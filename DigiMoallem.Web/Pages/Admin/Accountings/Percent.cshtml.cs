using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigiMoallem.BLL.DTOs.Accountings;
using DigiMoallem.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DigiMoallem.Web.Pages.Admin.Accountings
{
    public class PercentModel : PageModel
    {
        //private IAccountingService _accountingService;
        //private ICourseService _courseService;

        //public PercentModel(IAccountingService accountingService, ICourseService courseService)
        //{
        //    _accountingService = accountingService;
        //    _courseService = courseService;
        //}

        //[BindProperty]
        //public TeacherPercentViewModel TeacherPercentVM { get; set; }

        //public async Task OnGet()
        //{
        //    List<SelectListItem> courses = await _courseService
        //        .GetCoursesItemListAsync2();
        //    ViewData["Courses"] = new SelectList(courses, "Value", "Text");
        //}

        //public async Task<IActionResult> OnPostAsync()
        //{

        //    if (ModelState.IsValid)
        //    {
        //        // user inputs is valid

        //        if (await _accountingService.AddTeacherPercentAsync(TeacherPercentVM))
        //        {
        //            // success
        //            TempData["Success"] = "درصد استاد با موفقیت ثبت شد.";
        //            return RedirectToPage("Index");
        //        }

        //        // failure
        //        TempData["OperationFailed"] = "متاسفانه عملیات افزودن تراکنش توسط حسابدار با مشکل روبرو شد.";
        //        return Page();
        //    }

        //    // user inputs is not valid
        //    TempData["WrongInputs"] = "ورودی شما نامعتبر است.";
        //    return Page();
        //}
    }
}