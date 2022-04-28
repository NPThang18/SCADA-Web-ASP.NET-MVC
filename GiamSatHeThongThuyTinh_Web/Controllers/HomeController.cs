using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GiamSatHeThongThuyTinh_Web.Models;

namespace GiamSatHeThongThuyTinh_Web.Controllers
{
    public class HomeController : Controller
    {
        GiamSatHeThongThuyTinhDbContext db = new GiamSatHeThongThuyTinhDbContext();
        // GET: Home
        public ActionResult Index(string date)
        {
            if (date == null)
            {
                var data = db.Efficiencies.ToList();
                return View(data);
            } else
            {
                var data = db.Efficiencies.Where(m => m.Date == date).ToList();
                return View(data);
            }
        }
        public ActionResult Efficiency(string date)
        {
            if (date == null)
            {
                var data = db.Efficiencies.ToList();
                return View(data);
            } else
            {
                var data = db.Efficiencies.Where(m => m.Date == date).ToList();
                return View(data);
            }
            
        }
        public ActionResult Product(string date)
        {
            if (date == null)
            {
                var data = db.Products.ToList();
                return View(data);
            } else
            {
                var data = db.Products.Where(m => m.Date == date).ToList();
                return View(data);
            }
        }
        public ActionResult ProductOfDay(string date)
        {
            if (date == null)
            {
                var data = db.ProductOfDays.ToList();
                return View(data);
            } else
            {
                var data = db.ProductOfDays.Where(m => m.Date == date).ToList();
                return View(data);
            }
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
    }
}