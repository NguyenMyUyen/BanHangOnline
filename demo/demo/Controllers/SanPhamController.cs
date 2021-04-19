using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using demo.Models;

namespace demo.Controllers
{

    public class SanPhamController : Controller
    {
        // GET: SanPham
        sanphamEntities db = new sanphamEntities();
        [ChildActionOnly]
        //tao 2 partial view sp
        public ActionResult SanPhamStyle1Partial()
        {
            return PartialView();
        }

    }
}