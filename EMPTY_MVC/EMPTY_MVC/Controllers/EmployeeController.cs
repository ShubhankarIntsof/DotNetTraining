using EMPTY_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EMPTY_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employee = from e in GetEmployeesList()
                           orderby e.ID
                           select e;
            return View(employee);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
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

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
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

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
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
        public List<Employee> GetEmployeesList()
        {
            return new List<Models.Employee>
            {
                new Employee
                {
                    ID = 1,
                    Name = "Shubhankar",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21

                },new Employee
                                {
                    ID = 2,
                    Name = "Sasikant",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21

                },new Employee
                                {
                    ID = 3,
                    Name = "Chaitanya",
                    JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
                    Age = 21

                }
            };
        }


    }
}
