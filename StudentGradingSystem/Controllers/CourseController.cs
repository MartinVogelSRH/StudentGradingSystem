using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentGradingSystem.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Display()
        {
            return View();
        }
        public IActionResult Grade()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}