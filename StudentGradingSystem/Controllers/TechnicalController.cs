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
                QuestionnaireQuestions ExampleQuestionA = new QuestionnaireQuestions 
                {
                    QuestionID = 1,
                    Description = "How good was the big data visualized",
                    GoodReference = "Easily understandable",
                    BadReference = "Confusing",
                    Weighting = 10,
                    QuestionnaireCategory = ExampleCategory1
                };
                QuestionnaireQuestions ExampleQuestionB = new QuestionnaireQuestions
                {
                    QuestionID = 2,
                    Description = "What is big data analytics",
                    GoodReference = "Difficult to understand ",
                    BadReference = "Very less details ",
                    Weighting = 20,
                    QuestionnaireCategory = ExampleCategory1
                
                };
                   QuestionnaireQuestions ExampleQuestionC= new QuestionnaireQuestions
                   {
                       QuestionID = 3,
                    Description = "What is big data ",
                    GoodReference = "Meaningfull data",
                    BadReference = " Some key points were misssing ",
                    Weighting = 20,
                    QuestionnaireCategory = ExampleCategory2
                   };
                   QuestionnaireQuestions ExampleQuestionD= new QuestionnaireQuestions
                   { 
                       QuestionID = 4,
                    Description = " Give some examples of big data ",
                    GoodReference = " awesome",
                    BadReference = " Lot of details ",
                    Weighting = 10,
                    QuestionnaireCategory = ExampleCategory2
                   };
                    
                      QuestionnaireAnswers ExampleAnswers1 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionA,
                          AnswerID = 1,
                          Score = 10
                      }; 
                    QuestionnaireAnswers ExampleAnswers2 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionA,
                          AnswerID = 2,
                          Score = 10
                      }; 
                    QuestionnaireAnswers ExampleAnswers3= new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionB,
                          AnswerID = 1,
                          Score = 20
                      }; 
                                            QuestionnaireAnswers ExampleAnswers4 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionB,
                          AnswerID = 2,
                          Score = 20
                      }; 
                    QuestionnaireAnswers ExampleAnswers5 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionC,
                          AnswerID = 1,
                          Score = 20
                      }; 

                    QuestionnaireAnswers ExampleAnswers6 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionC,
                          AnswerID = 2,
                          Score = 20
                      }; 
                   QuestionnaireAnswers ExampleAnswers7 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionD,
                          AnswerID = 1,
                          Score = 10
                      }; 
                   QuestionnaireAnswers ExampleAnswers8 = new QuestionnaireAnswers
                      {
                          Question = ExampleQuestionD,
                          AnswerID = 2,
                          Score = 10
                      }; 
                      Module ExampleModule = new Module
                      {
                         
                         TemplateQuestionnaireID = ExampleQuestionnaire,
                         Description = "SAD"
                      };

                      ModuleDetails ExampleModuleDetails = new ModuleDetails
                      {
                        ModuleID = ExampleModule,
                        CourseNumber =1,
                        QuestionnaireID = ExampleQuestionnaire,
                        StartTime = new DateTime(2017,04,23),
                        EndTime = new DateTime(2017,05,18),
                        UserNameProfessor = "Professor1@abc.com"
                       };

                        GroupModule ExampleGroupModule = new GroupModule
                        { 
                            ModuleDetail = ExampleModuleDetails,
                            GroupModuleID = 1,
                            GroupName ="abc",
                        };
                         StudentCourse ExampleStudentCourse = new StudentCourse
                        {
                          
                          UserNameStudent  = "Student1@abc.come",
                          Course= ExampleModuleDetails,
                          SelfEvaluationID  = 1,
                          AnswerID =2,
                          GroupGradeOK  = true,
                          Group = ExampleGroupModule,
                          SelfEvaluationGrade = 3,
                          GroupGrade = 4,
                          ProfessorGuessGrade = 10,
                           Grade=10,

                        };
                              
                             

                            _context.Questionnaire.Add(ExampleQuestionnaire);
                            _context.QuestionnaireCategories.Add(ExampleCategory1);
                            _context.QuestionnaireCategories.Add(ExampleCategory2);
                            _context.QuestionnaireQuestions.Add(ExampleQuestionA);
                            _context.QuestionnaireQuestions.Add(ExampleQuestionB);
                            _context.QuestionnaireQuestions.Add(ExampleQuestionC);
                            _context.QuestionnaireQuestions.Add(ExampleQuestionD);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers1);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers2);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers3);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers4);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers5);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers6);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers7);
                            _context.QuestionnaireAnswers.Add(ExampleAnswers8);
                            _context.Module.Add(ExampleModule);
                            _context.ModuleDetails.Add(ExampleModuleDetails);
                            _context.GroupModule.Add(ExampleGroupModule);
                            _context.StudentCourse.Add(ExampleStudentCourse);
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