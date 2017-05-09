using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentGradingSystem.Controllers
{
    public class ModuleController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Display()
        {
            return View();
        }
    }
}