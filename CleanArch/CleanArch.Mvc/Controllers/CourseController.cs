﻿using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [Authorize]
        public IActionResult Index()
        {
            //CourseViewModel model = _courseService.GetCources();
            //return View(model);
            return View(_courseService.GetCourses());
        }
    }
}
