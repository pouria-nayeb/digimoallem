using DigiMoallem.BLL.Helpers.Security;
using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Pages.Admin.Orders
{
    [PermissionChecker(42)]
    public class EditUserCourseModel : PageModel
    {
        private readonly IOrderService _orderService;
        private readonly ICourseService _courseService;
        private readonly IUserService _userService;
        private readonly ILogger<EditUserCourseModel> _logger;

        public EditUserCourseModel(ICourseService courseService,
            IOrderService orderService,
            IUserService userService,
            ILogger<EditUserCourseModel> logger)
        {
            _orderService = orderService;
            _courseService = courseService;
            _userService = userService;
            _logger = logger;
        }

        [BindProperty]
        public UserCourse UserCourse { get; set; }

        public SelectList Users { get; set; }

        public SelectList Courses { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            await FeedUsersAndCoursesAsync();

            UserCourse = await _orderService.GetUserCourseByIdAsync(id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _orderService.UpdateUserCourseAsync(UserCourse) != null)
                {
                    TempData["Success"] = "سفارش کاربر با موفقیت ویرایش شد.";

                    return RedirectToPage("Index");
                }
                else
                {
                    ViewData["Message"] = "متاسفانه عملیات ویرایش سفارش توسط ادمین با شکست روبرو شد";

                    await FeedUsersAndCoursesAsync();

                    return Page();
                }
            }

            ViewData["Message"] = "ورودی شما نامعتبر است.";

            await FeedUsersAndCoursesAsync();

            return Page();
        }

        public async Task FeedUsersAndCoursesAsync()
        {
            Users = new SelectList(await _userService.GetUserSelectListAsync(), "Value", "Text");
            Courses = new SelectList(await _courseService.GetCoursesItemListAsync(), "Value", "Text");
        }
    }
}