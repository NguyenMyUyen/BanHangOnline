using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBHDT1.Model;

namespace WebBHDT.Areas.Admin.Controllers
{
    public class Admin_userController : Controller
    {
        private WebBHDT1DbContext db = new WebBHDT1DbContext();

        // GET: Admin/Admin_user
        public ActionResult Index()
        {
            return View(db.Admin_user.ToList());
        }

        // GET: Admin/Admin_user/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_user admin_user = db.Admin_user.Find(id);
            if (admin_user == null)
            {
                return HttpNotFound();
            }
            return View(admin_user);
        }

        // GET: Admin/Admin_user/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Admin_user/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,PassWord,Email,Phone,Allowed")] Admin_user admin_user)
        {
            if (ModelState.IsValid)
            {
                db.Admin_user.Add(admin_user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin_user);
        }

        // GET: Admin/Admin_user/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_user admin_user = db.Admin_user.Find(id);
            if (admin_user == null)
            {
                return HttpNotFound();
            }
            return View(admin_user);
        }

        // POST: Admin/Admin_user/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,UserName,PassWord,Email,Phone,Allowed")] Admin_user admin_user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin_user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin_user);
        }

        // GET: Admin/Admin_user/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin_user admin_user = db.Admin_user.Find(id);
            if (admin_user == null)
            {
                return HttpNotFound();
            }
            return View(admin_user);
        }

        // POST: Admin/Admin_user/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin_user admin_user = db.Admin_user.Find(id);
            db.Admin_user.Remove(admin_user);
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
