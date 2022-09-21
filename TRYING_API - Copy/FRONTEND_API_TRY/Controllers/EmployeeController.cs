using FRONTEND_API_TRY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace FRONTEND_API_TRY.Controllers
{
    public class EmployeeController : Controller
    {
        private string BASE_URL = "https://localhost:44373/api/";
        // GET: Employee
        public ActionResult Index()
        {

            EmployeeClient EC = new EmployeeClient();

            ViewBag.ListEmployees = EC.Find();

            return View();
        }

        public ActionResult Find(int id)
        {

            EmployeeClient EC = new EmployeeClient();
            
            ViewBag.Employee = EC.FindID(id);

            return View();
        }
    }
}