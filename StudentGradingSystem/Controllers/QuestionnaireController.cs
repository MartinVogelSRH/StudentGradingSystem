using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StudentGradingSystem.Controllers
{
    public class QuestionnaireController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create_Template()
        {
            return View();
        }
        public IActionResult Display(int id)
        {
            return View();
        }
        public IActionResult Fill(int id, int AnswerID)
        {
            return View();
        }
    }
}