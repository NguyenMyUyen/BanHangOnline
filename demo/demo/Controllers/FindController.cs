using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;
namespace demo.Controllers
{
    public class FindController : Controller
    {
        sanphamEntities db = new sanphamEntities();
        // GET: Find
        public ActionResult KQTimKiem(string sTuKhoa)
        {
            var lstSP = db.SANPHAMs.Where(n => n.TenSP.Contains(sTuKhoa));
                return View(lstSP.OrderBy(n=>n.TenSP));
        }
    }
}