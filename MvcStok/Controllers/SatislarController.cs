using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class SatislarController : Controller
    {
        // GET: Satislar
        DbMvcStokEntities1 db = new DbMvcStokEntities1();
        public ActionResult Index()
        {
            var satislar = db.tblsatislar.ToList();
            return View(satislar);
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSatis(tblsatislar p)
        {
            return View();
        }
    }
}