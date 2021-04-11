using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.IO;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanHangDT.Model;

namespace WBanHang.Areas.Admin.Controllers
{
    public class SANPHAMController : Controller
    {
        private WebBanHangDTDbContext db = new WebBanHangDTDbContext();

        // GET: Admin/SANPHAM
        public ActionResult Index()
        {
            var sANPHAMs = db.SANPHAMs.Include(s => s.LOAI).Include(s => s.THUONGHIEU);
            return View(sANPHAMs.ToList());
        }

        // GET: Admin/SANPHAM/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // GET: Admin/SANPHAM/Create
        public ActionResult Create()
        {
            ViewBag.MaLoai = new SelectList(db.LOAIs, "MaLoai", "TenLoai");
            ViewBag.MaThuongHieu = new SelectList(db.THUONGHIEUx, "MaThuongHieu", "TenThuongHieu");
            return View();
        }

        // POST: Admin/SANPHAM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaThuongHieu,TenThuongHieu,SoLUong,MaLoai,HinhAnh,KichThuoc,NgaySanXuat,CPU,RAM,HeDieuHanh,MoTa,Mau,DonGia")] SANPHAM sANPHAM)
        {
            //string filename = Path.GetFileNameWithoutExtension(sANPHAM.ImageFile.FileName);
            //string extension = Path.GetExtension(sANPHAM.ImageFile.FileName);
            //sANPHAM.HinhAnh = "~/Areas/Admin/Context/imgaes" + filename;
            //filename = Path.Combine(Server.MapPath("~/Areas/Admin/Context/imgaes"), filename);
            //sANPHAM.ImageFile.SaveAs(filename);
            //using (WebBanHangDTDbContext db = new WebBanHangDTDbContext())
            //{
            //    db.SANPHAMs.Add(sANPHAM);
            //    db.SaveChanges();
            //}
            //ModelState.Clear();

            //    //if (ModelState.IsValid)
            //    //{
            //    //    string path = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(file.FileName));
            //    //    file.SaveAs(path);
            //    //    db.SANPHAMs.Add(new SANPHAM
            //    //    {
            //    //       HinhAnh = "~/Area/Admin/Content/Images/" + file.FileName
            //    //    });
            //    //    db.SaveChanges();
            //    //    return RedirectToAction("Index");
            //    //}
            //    if (ModelState.IsValid)
            //    {
            //        db.SANPHAMs.Add(sANPHAM);
            //        db.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
          

            ViewBag.MaLoai = new SelectList(db.LOAIs, "MaLoai", "TenLoai", sANPHAM.MaLoai);
            ViewBag.MaThuongHieu = new SelectList(db.THUONGHIEUx, "MaThuongHieu", "TenThuongHieu", sANPHAM.MaThuongHieu);
            return View(sANPHAM);
        }

        // GET: Admin/SANPHAM/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoai = new SelectList(db.LOAIs, "MaLoai", "TenLoai", sANPHAM.MaLoai);
            ViewBag.MaThuongHieu = new SelectList(db.THUONGHIEUx, "MaThuongHieu", "TenThuongHieu", sANPHAM.MaThuongHieu);
            return View(sANPHAM);
        }

        // POST: Admin/SANPHAM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaThuongHieu,TenThuongHieu,SoLUong,MaLoai,HinhAnh,KichThuoc,NgaySanXuat,CPU,RAM,HeDieuHanh,MoTa,Mau,DonGia")] SANPHAM sANPHAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sANPHAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoai = new SelectList(db.LOAIs, "MaLoai", "TenLoai", sANPHAM.MaLoai);
            ViewBag.MaThuongHieu = new SelectList(db.THUONGHIEUx, "MaThuongHieu", "TenThuongHieu", sANPHAM.MaThuongHieu);
            return View(sANPHAM);
        }

        // GET: Admin/SANPHAM/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            if (sANPHAM == null)
            {
                return HttpNotFound();
            }
            return View(sANPHAM);
        }

        // POST: Admin/SANPHAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            SANPHAM sANPHAM = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(sANPHAM);
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
