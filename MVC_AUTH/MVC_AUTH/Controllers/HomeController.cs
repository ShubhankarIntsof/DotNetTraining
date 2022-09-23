using MVC_AUTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_AUTH.Controllers
{
    public class HomeController : Controller
    {
        private readonly Employee2Entities EmployeeEntities = new Employee2Entities();
        // GET: Home
        [Authorize]
        public ActionResult Index()
        {
           
     
            return View(EmployeeEntities.Form_Users.ToList());
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Form_Users user)
        {
            bool IsValidUser = EmployeeEntities.Form_Users.Any
                (x => x.Username.ToLower() == user.Username && x.Password.ToLower() == user.Password);
            if (IsValidUser)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                TempData["Message"] = "You are authorized.";

                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return RedirectToAction("Index", "Home/Register");
        }

        public ActionResult Register()
        {
            //return RedirectToAction("Login");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Form_Users registerUser)
        {
            if (ModelState.IsValid)
            {
                EmployeeEntities.Form_Users.Add(registerUser);
                EmployeeEntities.SaveChanges();
                return RedirectToAction("Login");

            }
            return View();
        }
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}