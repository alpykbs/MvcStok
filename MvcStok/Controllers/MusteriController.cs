using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace MvcStok.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        DbMvcStokEntities1 db = new DbMvcStokEntities1();
        public ActionResult Index(int sayfa = 1)
        {
            //var musterilistele = db.tblmusteri.ToList();
            var musterilistele = db.tblmusteri.Where(x => x.durum == true).ToList().ToPagedList(sayfa, 3);
            return View(musterilistele);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniMusteri(tblmusteri p)
        {
            db.tblmusteri.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MusteriSil(tblmusteri p)
        {
            var MusteriBul = db.tblmusteri.Find(p.id);
            MusteriBul.durum = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}