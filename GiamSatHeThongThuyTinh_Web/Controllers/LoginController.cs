using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiamSatHeThongThuyTinh_Web.Models;

namespace GiamSatHeThongThuyTinh_Web.Controllers
{
    public class LoginController : Controller
    {
        GiamSatHeThongThuyTinhDbContext db = new GiamSatHeThongThuyTinhDbContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Account user)
        {
            var checkUserName = db.Accounts.Where(m => m.UserName == user.UserName).SingleOrDefault();
            var checkPassword = db.Accounts.Where(m => m.Password == user.Password);
            if(checkPassword != null && checkUserName != null && ModelState.IsValid)
            {
                return RedirectToAction("index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "UserName or Password incorrect");
                ViewBag.error = "Tên đăng nhập hoặc mật khẩu không đúng";
                return View(user);
            }
        }
    }
}