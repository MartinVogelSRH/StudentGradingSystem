using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc.SelectList;
using StudentGradingSystem.Models;
using Microsoft.EntityFrameworkCore;
using StudentGradingSystem.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentGradingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomePage()
        {
            var modules = _context.Module.OrderBy(m => m.Description).Select(x => new { Id = x.ModuleID, Value = x.Description }).ToList();
            var module_details = _context.ModuleDetails.OrderByDescending(md => md.StartTime).Select(x => new { Id = x.ModuleDetailsID, Value = x.StartTime }).ToList();
            ViewBag.ListOfModules = modules;
            ViewBag.ModuleDetails = module_details;
            return View();
            
        }
        //[HttpPost]
        //public IActionResult HomePage(Module model)
        //{
        //    var selectedModule = Convert.ToInt32(model.ModuleID);
        //    var module_details = _context.ModuleDetails.OrderByDescending(md => md.StartTime).Select(x => new { Id = Convert.ToInt32(x.ModuleID), Value = x.StartTime }).ToList();
        //    var temp = module_details.Where(x => x.Id == model.ModuleID);
        //    //var module_details=_context.ModuleDetails.OrderByDescending(md=>md.StartTime).Where(x=> x.ModuleID== selectedModule)
        //    ViewBag.ModuleDetails = temp;
        //    return View();
        //}


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        //Course-Grade
        public IActionResult Grade(){
            return View();
        }
        
        public ActionResult GradeStudent(){
            return RedirectToAction("Grade","Course");
        }
    }
}
