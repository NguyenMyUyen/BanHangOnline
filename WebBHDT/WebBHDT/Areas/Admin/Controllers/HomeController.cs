using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBHDT1.Model; 

namespace WebBHDT.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        WebBHDT1DbContext db = new WebBHDT1DbContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            Admin_user user = db.Admin_user.SingleOrDefault(x => x.UserName == username && x.PassWord == password && x.Allowed == 1);
            if (user != null)
            {
                Session["userid"] = user.UserId;
                Session["username"] = user.UserName;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Sai tên đăng nhập hoặc mật khẩu ";
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }
}