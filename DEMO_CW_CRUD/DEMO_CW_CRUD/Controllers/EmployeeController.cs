using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DEMO_CW_CRUD;

namespace DEMO_CW_CRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private Freshers_Training2022Entities2 db = new Freshers_Training2022Entities2();

        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employee_Shuba.ToList());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            if (employee_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(employee_Shuba);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Address,Email")] Employee_Shuba employee_Shuba)
        {
            if (ModelState.IsValid)
            {
                db.Employee_Shuba.Add(employee_Shuba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee_Shuba);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            if (employee_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(employee_Shuba);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Address,Email")] Employee_Shuba employee_Shuba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee_Shuba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee_Shuba);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            if (employee_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(employee_Shuba);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee_Shuba employee_Shuba = db.Employee_Shuba.Find(id);
            db.Employee_Shuba.Remove(employee_Shuba);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
