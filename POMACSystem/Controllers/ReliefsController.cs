using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using POMACSystem.Models;

namespace POMACSystem.Controllers
{
    public class ReliefsController : Controller
    {
        private PomacDBEntities1 db = new PomacDBEntities1();

        // GET: Reliefs
        public ActionResult Index()
        {
            return View(db.Reliefs.ToList());
        }

        // GET: Reliefs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relief relief = db.Reliefs.Find(id);
            if (relief == null)
            {
                return HttpNotFound();
            }
            return View(relief);
        }

        // GET: Reliefs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reliefs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReliefID,ReliefName")] Relief relief)
        {
            if (ModelState.IsValid)
            {
                db.Reliefs.Add(relief);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relief);
        }

        // GET: Reliefs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relief relief = db.Reliefs.Find(id);
            if (relief == null)
            {
                return HttpNotFound();
            }
            return View(relief);
        }

        // POST: Reliefs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReliefID,ReliefName")] Relief relief)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relief).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relief);
        }

        // GET: Reliefs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relief relief = db.Reliefs.Find(id);
            if (relief == null)
            {
                return HttpNotFound();
            }
            return View(relief);
        }

        // POST: Reliefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Relief relief = db.Reliefs.Find(id);
            db.Reliefs.Remove(relief);
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
