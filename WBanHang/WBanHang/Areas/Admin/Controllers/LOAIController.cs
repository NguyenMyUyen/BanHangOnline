using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanHangDT.Model;

namespace WBanHang.Areas.Admin.Controllers
{
    public class LOAIController : Controller
    {
        private WebBanHangDTDbContext db = new WebBanHangDTDbContext();

        // GET: Admin/LOAI
        public ActionResult Index()
        {
            return View(db.LOAIs.ToList());
        }

        // GET: Admin/LOAI/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAI lOAI = db.LOAIs.Find(id);
            if (lOAI == null)
            {
                return HttpNotFound();
            }
            return View(lOAI);
        }

        // GET: Admin/LOAI/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LOAI/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoai,TenLoai")] LOAI lOAI)
        {
            if (ModelState.IsValid)
            {
                db.LOAIs.Add(lOAI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lOAI);
        }

        // GET: Admin/LOAI/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAI lOAI = db.LOAIs.Find(id);
            if (lOAI == null)
            {
                return HttpNotFound();
            }
            return View(lOAI);
        }

        // POST: Admin/LOAI/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoai,TenLoai")] LOAI lOAI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lOAI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lOAI);
        }

        // GET: Admin/LOAI/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LOAI lOAI = db.LOAIs.Find(id);
            if (lOAI == null)
            {
                return HttpNotFound();
            }
            return View(lOAI);
        }

        // POST: Admin/LOAI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LOAI lOAI = db.LOAIs.Find(id);
            db.LOAIs.Remove(lOAI);
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
