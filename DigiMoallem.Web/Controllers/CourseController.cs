using DigiMoallem.BLL.Interfaces;
using DigiMoallem.DAL.Entities.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DigiMoallem.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        private IOrderService _orderService;
        private IUserService _userServive;

        public CourseController(ICourseService courseService, IOrderService orderService, IUserService userServive)
        {
            _courseService = courseService;
            _orderService = orderService;
            _userServive = userServive;
        }

        /// <summary>
        /// Search, filter courses by many parameters
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="filter"></param>
        /// <param name="type"></param>
        /// <param name="orderBy"></param>
        /// <param name="startPrice"></param>
        /// <param name="endPrice"></param>
        /// <param name="selectedGroups"></param>
        /// <param name="take"></param>
        /// <returns></returns>
        [Route("Courses")]
        public async Task<IActionResult> Index(int pageId = 1,
            string filter = "",
            string type = "all",
            string orderBy = "date",
            int startPrice = 0,
            int endPrice = 0,
            List<int> selectedGroups = null,
            int take = 12)
        {

            ViewBag.SortedBy = orderBy;
            ViewBag.Type = type;
            ViewBag.SelectedGroups = selectedGroups;
            ViewBag.Groups = await _courseService.GetGroupsAsync();
            ViewBag.PageId = pageId;

            return View(await _courseService.GetCoursesAsync(pageId,
             filter,
             type,
             orderBy,
             startPrice,
             endPrice,
             selectedGroups,
             take));
        }

        /// <summary>
        /// Display course details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Course/{id}")]
        public async Task<IActionResult> DisplayCourse(int id)
        {
            var course = await _courseService.GetCourseAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        /// <summary>
        /// Add comment to course
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Course/{comment}")]
        public IActionResult DisplayCourse(Comment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userServive.GetUserIdByUserName(User.Identity.Name);
            comment.ReadByAdmin = false;
            _courseService.AddComment(comment);
            // success
            return View("ShowComment", _courseService.GetComments(comment.CourseId));
        }

        /// <summary>
        /// Show comments to clients
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pageId"></param>
        /// <returns></returns>
        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_courseService.GetComments(id, pageId));
        }

        /// <summary>
        /// Add course to user's shopping cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [Route("OrderCourse/{id}")]
        public async Task<IActionResult> OrderCourse(int id)
        {
            var orderId = await _orderService.AddOrderAsync(User.Identity.Name, id);
            if (orderId > 0)
            {
                // success
                return Redirect("/Cart/" + orderId);
            }
            else
            {
                // failure
                return BadRequest();
            }
        }

        /// <summary>
        /// Remove the order from user's shopping cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DeleteOrder/{id}")]
        public async Task<IActionResult> RemoveOrder(int id)
        {
            var orderId = await _orderService.RemoveOrderAsync(User.Identity.Name, id);

            if (orderId > 0)
            {
                // success
                return Redirect("/Cart/" + orderId);
            }
            else
            {
                // failure
                return BadRequest();
            }
        }

        [Route("Help")]
        public IActionResult Help() 
        {
            return View();
        }

        [Route("Cvs/{id}")]
        public IActionResult DisplayCvs(int? id) 
        {
            if (id == null)
            {
                return BadRequest();
            }

            var teacher = _userServive.GetUserById(id.Value);

            if (teacher == null)
            {
                return NotFound();
            }

            return View(teacher);
        }

        /// <summary>
        /// Let server download files for the user (Security)
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        [Route("DownloadFile/{id}")]
        public async Task<IActionResult> DownloadFile(int id)
        {
            var episode = _courseService.GetEpisodeById(id);

            string filePath = Path.Combine(Directory.GetCurrentDirectory() + "/wwwroot/CourseFiles/", episode.EpisodeFileName);

            string fileName = episode.EpisodeFileName;

            if (episode.IsFree)
            {
                // success - free
                byte[] file = await System.IO.File.ReadAllBytesAsync(filePath);
                return File(file, "application/force-download", fileName);
            }

            var userIdentity = User.Identity;
            if (userIdentity.IsAuthenticated)
            {
                // user detected
                if (await _orderService.IsUserBuyCourseAsync(userIdentity.Name, episode.CourseId))
                {
                    // success - bought
                    byte[] file = await System.IO.File.ReadAllBytesAsync(filePath);
                    return File(file, "application/force-download", fileName);
                }
            }

            // failure
            return Forbid();
        }

        [HttpGet]
        [Route("Rating/{id}")]
        public IActionResult Rating(int id, byte rate)
        {
            _courseService.AddRate(User.Identity.Name, id, rate);
            return Content("تست");
        }

        [Route("DisplayCourseTitles")]
        public IActionResult GetCourseTitles()
        {
            return Json(_courseService.GetCourseTitles());
        }
    }
}