using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService courseService;

        public CourseController(ICourseService courseService) => this.courseService = courseService;

        public async Task<IActionResult> Index()
        {
            CourseViewModel model = await courseService.GetCourses();
            return View(model);
        }
    }
}