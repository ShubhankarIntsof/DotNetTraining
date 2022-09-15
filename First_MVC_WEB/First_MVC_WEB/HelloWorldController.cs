using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC_WEB
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorldController
        public string Index()
        {
            //return View();
            return "I am Shubhankar";
        }

        // GET: HelloWorldController/Details/5
        public string Details(string id)
        {
            return "I am Shubhankar " + id;              
        }
        //public ActionResult Index()
        //{
        //    return View();
        //    //return "I am Shubhankar";
        //}

        //// GET: HelloWorldController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: HelloWorldController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HelloWorldController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorldController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloWorldController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorldController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloWorldController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
