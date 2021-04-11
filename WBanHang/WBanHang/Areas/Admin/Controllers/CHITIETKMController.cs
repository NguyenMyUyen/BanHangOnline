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
    public class CHITIETKMController : Controller
    {
        private WebBanHangDTDbContext db = new WebBanHangDTDbContext();

        // GET: Admin/CHITIETKM
        public ActionResult Index()
        {
            var cHITIETKMs = db.CHITIETKMs.Include(c => c.KHUYENMAI).Include(c => c.SANPHAM);
            return View(cHITIETKMs.ToList());
        }

        // GET: Admin/CHITIETKM/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKM cHITIETKM = db.CHITIETKMs.Find(id);
            if (cHITIETKM == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETKM);
        }

        // GET: Admin/CHITIETKM/Create
        public ActionResult Create()
        {
            ViewBag.MaKhuyenMai = new SelectList(db.KHUYENMAIs, "MaKhuyenMai", "TenKhuyenMai");
            ViewBag.MaSanPham = new SelectList(db.SANPHAMs, "MaSanPham", "TenSanPham");
            return View();
        }

        // POST: Admin/CHITIETKM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaKhuyenMai,MaSanPham,PHANTRAMKM")] CHITIETKM cHITIETKM)
        {
            if (ModelState.IsValid)
            {
                db.CHITIETKMs.Add(cHITIETKM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaKhuyenMai = new SelectList(db.KHUYENMAIs, "MaKhuyenMai", "TenKhuyenMai", cHITIETKM.MaKhuyenMai);
            ViewBag.MaSanPham = new SelectList(db.SANPHAMs, "MaSanPham", "TenSanPham", cHITIETKM.MaSanPham);
            return View(cHITIETKM);
        }

        // GET: Admin/CHITIETKM/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKM cHITIETKM = db.CHITIETKMs.Find(id);
            if (cHITIETKM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaKhuyenMai = new SelectList(db.KHUYENMAIs, "MaKhuyenMai", "TenKhuyenMai", cHITIETKM.MaKhuyenMai);
            ViewBag.MaSanPham = new SelectList(db.SANPHAMs, "MaSanPham", "TenSanPham", cHITIETKM.MaSanPham);
            return View(cHITIETKM);
        }

        // POST: Admin/CHITIETKM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaKhuyenMai,MaSanPham,PHANTRAMKM")] CHITIETKM cHITIETKM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cHITIETKM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaKhuyenMai = new SelectList(db.KHUYENMAIs, "MaKhuyenMai", "TenKhuyenMai", cHITIETKM.MaKhuyenMai);
            ViewBag.MaSanPham = new SelectList(db.SANPHAMs, "MaSanPham", "TenSanPham", cHITIETKM.MaSanPham);
            return View(cHITIETKM);
        }

        // GET: Admin/CHITIETKM/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CHITIETKM cHITIETKM = db.CHITIETKMs.Find(id);
            if (cHITIETKM == null)
            {
                return HttpNotFound();
            }
            return View(cHITIETKM);
        }

        // POST: Admin/CHITIETKM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CHITIETKM cHITIETKM = db.CHITIETKMs.Find(id);
            db.CHITIETKMs.Remove(cHITIETKM);
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
