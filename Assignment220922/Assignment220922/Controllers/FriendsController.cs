using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment220922.Models;

namespace Assignment220922.Controllers
{
    public class FriendsController : Controller
    {
        private Freshers_Training2022Entities db = new Freshers_Training2022Entities();

        // GET: Friends
        public ActionResult Index()
        {
            return View(db.Friends_Shuba.ToList());
        }

        // GET: Friends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends_Shuba friends_Shuba = db.Friends_Shuba.Find(id);
            if (friends_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(friends_Shuba);
        }

        // GET: Friends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Friends/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FriendId,FriendName,Place")] Friends_Shuba friends_Shuba)
        {
            if (ModelState.IsValid)
            {
                db.Friends_Shuba.Add(friends_Shuba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(friends_Shuba);
        }

        // GET: Friends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends_Shuba friends_Shuba = db.Friends_Shuba.Find(id);
            if (friends_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(friends_Shuba);
        }

        // POST: Friends/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FriendId,FriendName,Place")] Friends_Shuba friends_Shuba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(friends_Shuba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(friends_Shuba);
        }

        // GET: Friends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Friends_Shuba friends_Shuba = db.Friends_Shuba.Find(id);
            if (friends_Shuba == null)
            {
                return HttpNotFound();
            }
            return View(friends_Shuba);
        }

        // POST: Friends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Friends_Shuba friends_Shuba = db.Friends_Shuba.Find(id);
            db.Friends_Shuba.Remove(friends_Shuba);
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
