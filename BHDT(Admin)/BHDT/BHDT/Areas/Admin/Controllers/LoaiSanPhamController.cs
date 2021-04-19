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
    public class LoaiSanPhamController : Controller
    {
        private BHDTDbContext db = new BHDTDbContext();

        // GET: Admin/LoaiSanPham
        public ActionResult Index()
        {
            return View(db.LoaiSanPhams.ToList());
        }

        // GET: Admin/LoaiSanPham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanPham loaiSanPham = db.LoaiSanPhams.Find(id);
            if (loaiSanPham == null)
            {
                return HttpNotFound();
            }
            return View(loaiSanPham);
        }

        // GET: Admin/LoaiSanPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiSP,TenLoai,Icon,BiDanh")] LoaiSanPham loaiSanPham)
        {
            if (ModelState.IsValid)
            {
                db.LoaiSanPhams.Add(loaiSanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiSanPham);
        }

        // GET: Admin/LoaiSanPham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanPham loaiSanPham = db.LoaiSanPhams.Find(id);
            if (loaiSanPham == null)
            {
                return HttpNotFound();
            }
            return View(loaiSanPham);
        }

        // POST: Admin/LoaiSanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiSP,TenLoai,Icon,BiDanh")] LoaiSanPham loaiSanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiSanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiSanPham);
        }

        // GET: Admin/LoaiSanPham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanPham loaiSanPham = db.LoaiSanPhams.Find(id);
            if (loaiSanPham == null)
            {
                return HttpNotFound();
            }
            return View(loaiSanPham);
        }

        // POST: Admin/LoaiSanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LoaiSanPham loaiSanPham = db.LoaiSanPhams.Find(id);
            db.LoaiSanPhams.Remove(loaiSanPham);
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
