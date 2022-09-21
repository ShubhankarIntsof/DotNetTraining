using DEMO_FrontEnd.Models;
using DEMO_FrontEnd.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace DEMO_FrontEnd.Controllers
{
    
    public class EmployeeController : Controller
    {
        private string BASE_URL = "https://localhost:44306/api/";
        // GET: Employee
        public ActionResult Index()
        {
            List<EmployeeModel> employee = new List<EmployeeModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BASE_URL);

            HttpResponseMessage response = client.GetAsync("Employee_Shuba").Result;
            //var response = client.GetAsync("Employee_Shuba").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                employee = JsonConvert.DeserializeObject<List<EmployeeModel>>(result);
            }
            
            //EmployeeClient EC = new EmployeeClient();
            ////Console.WriteLine(EC.ToString());
            ////ViewBag.list = EC.FindAll();
            ViewBag.list = employee;

            return View(new EmployeeModel());
        }
    }
}