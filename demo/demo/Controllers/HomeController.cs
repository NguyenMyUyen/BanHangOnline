using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;

namespace demo.Controllers
{
    public class HomeController : Controller
    { sanphamEntities db = new sanphamEntities();
        public ActionResult Index()
        {
            var lstLAP = db.SANPHAMs.Where(n => n.MALOAISP == 1);
            //Gan vao viewbag
            ViewBag.ListLAPTOP = lstLAP;
            return View();
        }

    }
}