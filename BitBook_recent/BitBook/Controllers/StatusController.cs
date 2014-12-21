using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BitBook.Models;

namespace BitBook.Controllers
{
    public class StatusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Status/
        public ActionResult Index()
        {
            return View(db.Status.ToList());
        }

        // GET: /Status/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeStatus homestatus = db.Status.Find(id);
            if (homestatus == null)
            {
                return HttpNotFound();
            }
            return View(homestatus);
        }

        // GET: /Status/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Status/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HomeStatusId,StatusName,FullName")] HomeStatus homestatus)
        {
            if (ModelState.IsValid)
            {
                db.Status.Add(homestatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homestatus);
        }

        // GET: /Status/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeStatus homestatus = db.Status.Find(id);
            if (homestatus == null)
            {
                return HttpNotFound();
            }
            return View(homestatus);
        }

        // POST: /Status/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HomeStatusId,StatusName,FullName")] HomeStatus homestatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homestatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homestatus);
        }

        // GET: /Status/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeStatus homestatus = db.Status.Find(id);
            if (homestatus == null)
            {
                return HttpNotFound();
            }
            return View(homestatus);
        }

        // POST: /Status/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeStatus homestatus = db.Status.Find(id);
            db.Status.Remove(homestatus);
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

        public ActionResult PostStatus(string name, string status)
        {
            HomeStatus aStatus = new HomeStatus();
            aStatus.FullName = name;
            aStatus.StatusName = status;
            db.Status.Add(aStatus);
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
