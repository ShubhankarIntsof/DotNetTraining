using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MealMonkey.Models;

namespace MealMonkey.Controllers
{
    public class ProductsController : Controller
    {
        private ProductEntities db = new ProductEntities();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.MM_Products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Products mM_Products = db.MM_Products.Find(id);
            if (mM_Products == null)
            {
                return HttpNotFound();
            }
            return View(mM_Products);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,Name,Description,Price,Quantity,ImageUrl,CategoryId,IsActive,CreatedDate")] MM_Products mM_Products)
        {
            if (ModelState.IsValid)
            {
                db.MM_Products.Add(mM_Products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mM_Products);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Products mM_Products = db.MM_Products.Find(id);
            if (mM_Products == null)
            {
                return HttpNotFound();
            }
            return View(mM_Products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Name,Description,Price,Quantity,ImageUrl,CategoryId,IsActive,CreatedDate")] MM_Products mM_Products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mM_Products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mM_Products);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MM_Products mM_Products = db.MM_Products.Find(id);
            if (mM_Products == null)
            {
                return HttpNotFound();
            }
            return View(mM_Products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MM_Products mM_Products = db.MM_Products.Find(id);
            db.MM_Products.Remove(mM_Products);
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
