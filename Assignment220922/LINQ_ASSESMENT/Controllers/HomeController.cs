using LINQ_ASSESMENT.DbContext_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LINQ_ASSESMENT.Controllers
{
    public class HomeController : Controller
    {
        FriendDbContext Fd = new FriendDbContext();
        public ActionResult Index()
        {
            var Details = from x in Fd.Friends_Shuba select x;
            return View(Details);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}