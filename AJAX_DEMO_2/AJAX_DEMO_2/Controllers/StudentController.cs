using AJAX_DEMO_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;

namespace AJAX_DEMO_2.Controllers
{
    public class StudentController : Controller
    {
        StudentContext context = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [WebMethod]
        public string CreateStudent(Student obj)
        {
            obj.Id = 1;
            context.ShubaStudents.Add(obj);
            context.SaveChanges();
            string message = "Data Saved";

            //return Json(new {Message = message , JsonRequestBehavior.AllowGet });
            return "Done" + message;

        }
        
        public ActionResult GetStudent(string id)
        {
            List<Student> students = new List<Student>();
            students = context.ShubaStudents.ToList();

            return Json(students,JsonRequestBehavior.AllowGet);
        }



    }
}