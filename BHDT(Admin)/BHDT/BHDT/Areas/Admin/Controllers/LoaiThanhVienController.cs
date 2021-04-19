using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BHDT.Model;

namespace BHDT.Areas.Admin.Controllers
{
    public class LoaiThanhVienController : Controller
    {
        private BHDTDbContext db = new BHDTDbContext();

        // GET: Admin/LoaiThanhVien
        public ActionResult Index()
        {
            return View(db.LoaiThanhViens.ToList());
        }

        // GET: Admin/LoaiThanhVien/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThanhVien loaiThanhVien = db.LoaiThanhViens.Find(id);
            if (loaiThanhVien == null)
            {
                return HttpNotFound();
            }
            return View(loaiThanhVien);
        }

        // GET: Admin/LoaiThanhVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiThanhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiTV,TenLoai,UuDai")] LoaiThanhVien loaiThanhVien)
        {
            if (ModelState.IsValid)
            {
                db.LoaiThanhViens.Add(loaiThanhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiThanhVien);
        }

        // GET: Admin/LoaiThanhVien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThanhVien loaiThanhVien = db.LoaiThanhViens.Find(id);
            if (loaiThanhVien == null)
            {
                return HttpNotFound();
            }
            return View(loaiThanhVien);
        }

        // POST: Admin/LoaiThanhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiTV,TenLoai,UuDai")] LoaiThanhVien loaiThanhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiThanhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiThanhVien);
        }

        // GET: Admin/LoaiThanhVien/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiThanhVien loaiThanhVien = db.LoaiThanhViens.Find(id);
            if (loaiThanhVien == null)
            {
                return HttpNotFound();
            }
            return View(loaiThanhVien);
        }

        // POST: Admin/LoaiThanhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiThanhVien loaiThanhVien = db.LoaiThanhViens.Find(id);
            db.LoaiThanhViens.Remove(loaiThanhVien);
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
