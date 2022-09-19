using DotNetCore_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCore_Web_Api.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display(Employee emp)
        {
            string Name = emp.Name;
            string Address = emp.Address;
            string Designation = emp.Designation;


            return Content("Name: " + Name + "\nAddress: " + Address + "\nDesignation: " + Designation);

        }
        public ActionResult MyEmp()
        {
            Employee obj1 = new Employee()
            {
                Name = "Ayush",
                Address = "Mumbai",
                Designation = "Project"
            };

            ViewData["EmpDetails"] = obj1;
            return View();
        }

    }
}