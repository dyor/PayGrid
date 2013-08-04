using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayGrid.Models;

namespace PayGrid.Views
{
    public class WebEventController : Controller
    {
        private WebEventDBContext db = new WebEventDBContext();

        //
        // GET: /WebEvent/

        public ActionResult Index()
        {
            return View(db.WebEvent.ToList());
        }

        //
        // GET: /WebEvent/Details/5

        public ActionResult Details(int id = 0)
        {
            WebEvent webevent = db.WebEvent.Find(id);
            if (webevent == null)
            {
                return HttpNotFound();
            }
            return View(webevent);
        }

        //
        // GET: /WebEvent/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /WebEvent/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WebEvent webevent)
        {
            if (ModelState.IsValid)
            {
                db.WebEvent.Add(webevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(webevent);
        }

        //
        // GET: /WebEvent/Edit/5

        public ActionResult Edit(int id = 0)
        {
            WebEvent webevent = db.WebEvent.Find(id);
            if (webevent == null)
            {
                return HttpNotFound();
            }
            return View(webevent);
        }

        //
        // POST: /WebEvent/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WebEvent webevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(webevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(webevent);
        }

        //
        // GET: /WebEvent/Delete/5

        public ActionResult Delete(int id = 0)
        {
            WebEvent webevent = db.WebEvent.Find(id);
            if (webevent == null)
            {
                return HttpNotFound();
            }
            return View(webevent);
        }

        //
        // POST: /WebEvent/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WebEvent webevent = db.WebEvent.Find(id);
            db.WebEvent.Remove(webevent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}