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
    public class ThanhVienController : Controller
    {
        private BHDTDbContext db = new BHDTDbContext();

        // GET: Admin/ThanhVien
        public ActionResult Index()
        {
            var thanhViens = db.ThanhViens.Include(t => t.LoaiThanhVien);
            return View(thanhViens.ToList());
        }

        // GET: Admin/ThanhVien/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhVien thanhVien = db.ThanhViens.Find(id);
            if (thanhVien == null)
            {
                return HttpNotFound();
            }
            return View(thanhVien);
        }

        // GET: Admin/ThanhVien/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiTV = new SelectList(db.LoaiThanhViens, "MaLoaiTV", "TenLoai");
            return View();
        }

        // POST: Admin/ThanhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTV,MaLoaiTV,TaiKhoan,MatKhau,HoTen,DiaChi,Email,SDT,CauHoi,CauTraLoi")] ThanhVien thanhVien)
        {
            if (ModelState.IsValid)
            {
                db.ThanhViens.Add(thanhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiTV = new SelectList(db.LoaiThanhViens, "MaLoaiTV", "TenLoai", thanhVien.MaLoaiTV);
            return View(thanhVien);
        }

        // GET: Admin/ThanhVien/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhVien thanhVien = db.ThanhViens.Find(id);
            if (thanhVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiTV = new SelectList(db.LoaiThanhViens, "MaLoaiTV", "TenLoai", thanhVien.MaLoaiTV);
            return View(thanhVien);
        }

        // POST: Admin/ThanhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTV,MaLoaiTV,TaiKhoan,MatKhau,HoTen,DiaChi,Email,SDT,CauHoi,CauTraLoi")] ThanhVien thanhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thanhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiTV = new SelectList(db.LoaiThanhViens, "MaLoaiTV", "TenLoai", thanhVien.MaLoaiTV);
            return View(thanhVien);
        }

        // GET: Admin/ThanhVien/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhVien thanhVien = db.ThanhViens.Find(id);
            if (thanhVien == null)
            {
                return HttpNotFound();
            }
            return View(thanhVien);
        }

        // POST: Admin/ThanhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThanhVien thanhVien = db.ThanhViens.Find(id);
            db.ThanhViens.Remove(thanhVien);
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
