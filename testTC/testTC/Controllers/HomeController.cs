using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testTC.Models;

namespace testTC.Controllers
{
    public class HomeController : Controller
    {
        BHDTEntities db = new BHDTEntities();
        public ActionResult Index()
        {
            List<SanPham> sp = db.SanPhams.ToList();
            return View(sp);

        }
        public ActionResult Listcategory()
        {
            var lst = db.LoaiSanPhams.Where(n => n.MaLoaiSP == 0).ToList();
            return View("_Listcategory", lst);
        }

    }
}
          