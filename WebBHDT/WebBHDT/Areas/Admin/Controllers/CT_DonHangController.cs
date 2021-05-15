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
    public class CT_DonHangController : Controller
    {
        private WebBHDT1DbContext db = new WebBHDT1DbContext();

        // GET: Admin/CT_DonHang
        public ActionResult Index()
        {
            var cT_DonHang = db.CT_DonHang.Include(c => c.DonHang).Include(c => c.SanPham);
            return View(cT_DonHang.ToList());
        }

        // GET: Admin/CT_DonHang/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_DonHang cT_DonHang = db.CT_DonHang.Find(id);
            if (cT_DonHang == null)
            {
                return HttpNotFound();
            }
            return View(cT_DonHang);
        }

        // GET: Admin/CT_DonHang/Create
        public ActionResult Create()
        {
            ViewBag.MaDDH = new SelectList(db.DonHangs, "MaDDH", "MaDDH");
            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP");
            return View();
        }

        // POST: Admin/CT_DonHang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDDH,MaSP,TenSP,SoLuong")] CT_DonHang cT_DonHang)
        {
            if (ModelState.IsValid)
            {
                db.CT_DonHang.Add(cT_DonHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaDDH = new SelectList(db.DonHangs, "MaDDH", "MaDDH", cT_DonHang.MaDDH);
            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", cT_DonHang.MaSP);
            return View(cT_DonHang);
        }

        // GET: Admin/CT_DonHang/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_DonHang cT_DonHang = db.CT_DonHang.Find(id);
            if (cT_DonHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDDH = new SelectList(db.DonHangs, "MaDDH", "MaDDH", cT_DonHang.MaDDH);
            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", cT_DonHang.MaSP);
            return View(cT_DonHang);
        }

        // POST: Admin/CT_DonHang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDDH,MaSP,TenSP,SoLuong")] CT_DonHang cT_DonHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cT_DonHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDDH = new SelectList(db.DonHangs, "MaDDH", "MaDDH", cT_DonHang.MaDDH);
            ViewBag.MaSP = new SelectList(db.SanPhams, "MaSP", "TenSP", cT_DonHang.MaSP);
            return View(cT_DonHang);
        }

        // GET: Admin/CT_DonHang/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CT_DonHang cT_DonHang = db.CT_DonHang.Find(id);
            if (cT_DonHang == null)
            {
                return HttpNotFound();
            }
            return View(cT_DonHang);
        }

        // POST: Admin/CT_DonHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CT_DonHang cT_DonHang = db.CT_DonHang.Find(id);
            db.CT_DonHang.Remove(cT_DonHang);
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
