using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstWeekWork.Models;

namespace FirstWeekWork.Controllers
{
    public class 客戶彙整資料ExController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        客戶彙整資料ExRepository repo = RepositoryHelper.Get客戶彙整資料ExRepository();

        // GET: 客戶彙整資料Ex
        public ActionResult Index()
        {
            return View(repo.All());

        }

        //// GET: 客戶彙整資料Ex/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    客戶彙整資料Ex 客戶彙整資料Ex = repo.Find(id);
        //    if (客戶彙整資料Ex == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(客戶彙整資料Ex);
        //}

        //// GET: 客戶彙整資料Ex/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: 客戶彙整資料Ex/Create
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,客戶名稱,聯絡人數量,銀行帳戶數量")] 客戶彙整資料Ex 客戶彙整資料Ex)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.客戶彙整資料Ex.Add(客戶彙整資料Ex);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(客戶彙整資料Ex);
        //}

        //// GET: 客戶彙整資料Ex/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    客戶彙整資料Ex 客戶彙整資料Ex = db.客戶彙整資料Ex.Find(id);
        //    if (客戶彙整資料Ex == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(客戶彙整資料Ex);
        //}

        //// POST: 客戶彙整資料Ex/Edit/5
        //// 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        //// 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,客戶名稱,聯絡人數量,銀行帳戶數量")] 客戶彙整資料Ex 客戶彙整資料Ex)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(客戶彙整資料Ex).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(客戶彙整資料Ex);
        //}

        //// GET: 客戶彙整資料Ex/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    客戶彙整資料Ex 客戶彙整資料Ex = db.客戶彙整資料Ex.Find(id);
        //    if (客戶彙整資料Ex == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(客戶彙整資料Ex);
        //}

        //// POST: 客戶彙整資料Ex/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    客戶彙整資料Ex 客戶彙整資料Ex = db.客戶彙整資料Ex.Find(id);
        //    db.客戶彙整資料Ex.Remove(客戶彙整資料Ex);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
