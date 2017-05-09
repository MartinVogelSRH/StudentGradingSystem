using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentGradingSystem.Models;
using StudentGradingSystem.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace StudentGradingSystem.Controllers
{
    public class TechnicalController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        private readonly IHostingEnvironment _env;
        private readonly IServiceProvider _services;
        public TechnicalController(IServiceProvider services, IHostingEnvironment env, ApplicationDbContext context)
        {
            _services = services;
            _context = context;
            _env = env;
        }
        // GET: Technical
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DeleteCreate()
        {
            if(_env.IsDevelopment())
            {
                if (await _context.Database.EnsureDeletedAsync())
                {
                    await _context.Database.MigrateAsync();
                    ViewData["DropDBResult"] = "True";
                }
            }
            
            return View("Index");
        }
        public ActionResult DeleteData()
        {
            if (_env.IsDevelopment())
            {
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.GroupModule");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.Module");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.ModuleDetails");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.Questionnaire");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.QuestionnaireAnswers");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.QuestionnaireCategories");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.QuestionnaireQuestions");
                _context.Database.ExecuteSqlCommand("DELETE FROM StudentGradingSystem.StudentCourse");
                ViewData["DataDeleted"] = "True";
            }

            return View("Index");
        }
        public ActionResult InsertSampleData()
        {
            if (_env.IsDevelopment())
            {
                Questionnaire ExampleQuestionnaire = new Questionnaire();
                QuestionnaireCategories ExampleCategory1 = new QuestionnaireCategories
                {
                    CategoryID = 1,
                    CategoryName = "Test Category 1",
                    QuestionnaireID = ExampleQuestionnaire,
                    Weighting = 30
                };
                QuestionnaireCategories ExampleCategory2 = new QuestionnaireCategories
                {
                    CategoryID = 2,
                    CategoryName = "Test Category 2",
                    QuestionnaireID = ExampleQuestionnaire,
                    Weighting = 30
                };
                _context.Questionnaire.Add(ExampleQuestionnaire);
                _context.QuestionnaireCategories.Add(ExampleCategory1);
                _context.QuestionnaireCategories.Add(ExampleCategory2);
                _context.SaveChanges();
            }

            
            return View("Index");
        }

        // GET: Technical/Details/5
        public ActionResult Details(int id)
        {
            return View();
            
        }

        // GET: Technical/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Technical/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Technical/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Technical/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Technical/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Technical/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}