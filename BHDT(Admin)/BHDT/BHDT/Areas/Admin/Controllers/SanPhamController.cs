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
    public class SanPhamController : Controller
    {
        private BHDTDbContext db = new BHDTDbContext();

        // GET: Admin/SanPham
        public ActionResult Index()
        {
            var sanPhams = db.SanPhams.Include(s => s.LoaiSanPham).Include(s => s.NhaCungCap).Include(s => s.NhaSanXuat);
            return View(sanPhams.ToList());
        }

        // GET: Admin/SanPham/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // GET: Admin/SanPham/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPhams, "MaLoaiSP", "TenLoai");
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNCC");
            ViewBag.MaNSX = new SelectList(db.NhaSanXuats, "MaNSX", "TenNSX");
            return View();
        }

        // POST: Admin/SanPham/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSP,TenSP,DonGia,NgayCapNhap,CauHinh,Mota,HinhAnh,SoLuongton,LuotXem,LuotBinhChon,SoLanMua,Moi,MaNCC,MaNSX,MaLoaiSP,DaXoa,Sale")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPhams, "MaLoaiSP", "TenLoai", sanPham.MaLoaiSP);
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNCC", sanPham.MaNCC);
            ViewBag.MaNSX = new SelectList(db.NhaSanXuats, "MaNSX", "TenNSX", sanPham.MaNSX);
            return View(sanPham);
        }

        // GET: Admin/SanPham/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPhams, "MaLoaiSP", "TenLoai", sanPham.MaLoaiSP);
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNCC", sanPham.MaNCC);
            ViewBag.MaNSX = new SelectList(db.NhaSanXuats, "MaNSX", "TenNSX", sanPham.MaNSX);
            return View(sanPham);
        }

        // POST: Admin/SanPham/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSP,TenSP,DonGia,NgayCapNhap,CauHinh,Mota,HinhAnh,SoLuongton,LuotXem,LuotBinhChon,SoLanMua,Moi,MaNCC,MaNSX,MaLoaiSP,DaXoa,Sale")] SanPham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiSP = new SelectList(db.LoaiSanPhams, "MaLoaiSP", "TenLoai", sanPham.MaLoaiSP);
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps, "MaNCC", "TenNCC", sanPham.MaNCC);
            ViewBag.MaNSX = new SelectList(db.NhaSanXuats, "MaNSX", "TenNSX", sanPham.MaNSX);
            return View(sanPham);
        }

        // GET: Admin/SanPham/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = db.SanPhams.Find(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            return View(sanPham);
        }

        // POST: Admin/SanPham/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SanPham sanPham = db.SanPhams.Find(id);
            db.SanPhams.Remove(sanPham);
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
