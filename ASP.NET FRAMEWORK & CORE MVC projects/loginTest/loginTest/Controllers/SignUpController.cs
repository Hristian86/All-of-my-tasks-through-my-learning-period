using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using loginTest.Models;

namespace loginTest.Controllers
{
    public class SignUpController : Controller
    {
        private RegistrationEntities db = new RegistrationEntities();

        // GET: SignUp
        public ActionResult Index()
        {
            return View(db.Authentication.ToList());
        }

        // GET: SignUp/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authentication authentication = db.Authentication.Find(id);
            if (authentication == null)
            {
                return HttpNotFound();
            }
            return View(authentication);
        }

        // GET: SignUp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SignUp/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,User,PassWord")] Authentication authentication)
        {
            if (ModelState.IsValid)
            {
                db.Authentication.Add(authentication);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(authentication);
        }

        // GET: SignUp/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authentication authentication = db.Authentication.Find(id);
            if (authentication == null)
            {
                return HttpNotFound();
            }
            return View(authentication);
        }

        // POST: SignUp/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,User,PassWord")] Authentication authentication)
        {
            if (ModelState.IsValid)
            {
                db.Entry(authentication).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(authentication);
        }

        // GET: SignUp/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Authentication authentication = db.Authentication.Find(id);
            if (authentication == null)
            {
                return HttpNotFound();
            }
            return View(authentication);
        }

        // POST: SignUp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Authentication authentication = db.Authentication.Find(id);
            db.Authentication.Remove(authentication);
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
