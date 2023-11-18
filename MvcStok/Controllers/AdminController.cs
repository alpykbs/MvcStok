using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DbMvcStokEntities1 db = new DbMvcStokEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult YeniAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniAdmin(tbladmin p)
        {
            db.tbladmin.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}