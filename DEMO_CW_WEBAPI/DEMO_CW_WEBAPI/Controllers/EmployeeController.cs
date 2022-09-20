using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DEMO_CW_WEBAPI.Controllers
{
    public class EmployeeController : ApiController
    {

        public IEnumerable<Employee_Shuba> Get()
        {
            using (Freshers_Training2022Entities context = new Freshers_Training2022Entities())
            {
                return context.Employee_Shuba.ToList();//returning all the employees in list object form
            }
        }



        public Employee_Shuba Get(int Id) // return employee on the basis of id
        {
            using (Freshers_Training2022Entities context = new Freshers_Training2022Entities())
            {
                return context.Employee_Shuba.FirstOrDefault(e => e.Id == Id);
            }
        }
    }
}
