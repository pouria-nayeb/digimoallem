using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DigiMoallem.Web.Pages.Admin.Courses
{
    public class DeleteCommentModel : PageModel
    {
        private readonly ICourseService _courseService;

        public DeleteCommentModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public Comment Comment { get; set; }

        public IActionResult OnGet(int? id)
        {
            return SeedInitialCommentData(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (_courseService.RemoveComment(Comment.CommentId) != null)
                {
                    // success
                    TempData["Success"] = "کامنت با موفقیت ویرایش شد.";
                    return RedirectToPage("Comments");
                }
                else
                {
                    // failure (db error)
                    ViewData["Failure"] = "متاسفانه عملیات افزودن درس توسط استاد با مشکل روبرو شد.";
                    return SeedInitialCommentData(Comment.CommentId);
                }
            }

            // admin inputs is not valid
            ViewData["Failure"] = "ورودی شما نامعتبر است.";
            return SeedInitialCommentData(Comment.CommentId);
        }

        private IActionResult SeedInitialCommentData(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Comment = _courseService.GetCommentById(id.Value);

            if (Comment == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}