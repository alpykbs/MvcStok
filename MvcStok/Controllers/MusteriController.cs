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
            var musterilistele = db.tblmusteri.ToList().ToPagedList(sayfa, 2);
            return View(musterilistele);
        }
    }
}