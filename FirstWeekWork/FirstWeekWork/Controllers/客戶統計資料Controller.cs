using FirstWeekWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWeekWork.Controllers
{
    public class 客戶統計資料Controller : Controller
    {
        // GET: 客戶統計資料
        public ActionResult Index()
        {
            var db = new 客戶統計資料VM();
            return View(db.客戶統計資料All());
        }

//        // GET: 客戶統計資料/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: 客戶統計資料/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: 客戶統計資料/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: 客戶統計資料/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: 客戶統計資料/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//                        }
//            catch
//{
//                return View();
//            }
//        }

//        // GET: 客戶統計資料/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: 客戶統計資料/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }
    }
}
