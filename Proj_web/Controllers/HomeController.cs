using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proj_web.Models;

namespace Proj_web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ShopContext db = new ShopContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View() ;
        }
        [HttpGet]
        public ActionResult Map()
        {
            IEnumerable<Shop> shops = db.Shops;
            // передаем все полученный объекты в динамическое свойство Shops в ViewBag
            ViewBag.Shops = shops;
            return View(shops);
        }
        [HttpPost]
        public JsonResult Map(string Adress)
        {
            var jsondata = db.Shops.ToList<Shop>();
            return Json(jsondata, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Admin()
        {
            IEnumerable<Shop> shops = db.Shops;
            ViewBag.Shops = shops;
            return View(shops);
        }
        [HttpGet]
        public ActionResult Create()
        {
            IEnumerable<Shop> shops = db.Shops;
            ViewBag.Shops = shops;
            return View(shops);
        }
        [HttpPost]
        public ActionResult Create(Shop new_shop)
        {
            db.Shops.Add(new_shop);
            // сохраняем в бд все изменения
            db.SaveChanges();
            IEnumerable<Shop> shops = db.Shops;
            ViewBag.Shops = shops;
            return RedirectToAction("Admin");
        }
        [HttpPost]
        public ActionResult Admin_del(int Id)
        {
            IEnumerable<Shop> shops = db.Shops.Where(a => a.Id == Id);
            db.Shops.RemoveRange(shops);
            db.SaveChanges();
            return RedirectToAction("Admin");
        }
        [HttpGet]
       
        
        public ActionResult Edit(int Id)
        {
            IEnumerable<Shop> shops = db.Shops.Where(a => a.Id == Id);
            ViewBag.Shops = Id;
            return View(shops);
        }
        [HttpPost]
        public ActionResult Edit(int Id, Shop edit_shop)
        {
            db.Shops.Single(a => a.Id == Id).Name = edit_shop.Name;
            db.Shops.Single(a => a.Id == Id).Phone = edit_shop.Phone;
            db.Shops.Single(a => a.Id == Id).Address = edit_shop.Address;
            db.Shops.Single(a => a.Id == Id).CoordinatesX = edit_shop.CoordinatesX;
            db.Shops.Single(a => a.Id == Id).CoordinatesY = edit_shop.CoordinatesY;
            db.Shops.Single(a => a.Id == Id).E_mail = edit_shop.E_mail;
            db.Shops.Single(a => a.Id == Id).in_adress = edit_shop.in_adress;
            db.SaveChanges();
            return RedirectToAction("Admin");
        }

    }
}
