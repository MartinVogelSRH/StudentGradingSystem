using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentGradingSystem.Controllers
{
    public class TechnicalController : Controller
    {
        // GET: Technical
        public ActionResult Index()
        {
            return View();
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