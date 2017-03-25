using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecondWeekWork.Models;
using PagedList;

namespace SecondWeekWork.Controllers
{
    public class 客戶聯絡人Controller : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        客戶聯絡人Repository repo = RepositoryHelper.Get客戶聯絡人Repository();

        // GET: 客戶聯絡人
        public ActionResult Index(string keyword, string sortBy, int pageNo = 1)       
        {
            var data = repo.All();
            var listReturn = new List<客戶聯絡人>();
            if (string.IsNullOrEmpty(keyword) == false)
            {
                //data = data.Where(s => s.姓名.Contains(keyword)
                //                    || s.手機.Contains(keyword)
                //                    || s.職稱.Contains(keyword)
                //                    || s.電話.Contains(keyword));
                data = data.Where(s => s.職稱.Contains(keyword));
            }

            ViewBag.keyword = keyword;
            ViewBag.sortBy = sortBy;
            ViewBag.pageNo = pageNo;

            if (string.IsNullOrEmpty(sortBy) == false)
            {
                switch (sortBy)
                {
                    case "+職稱":
                        data = data.OrderByDescending(s => s.職稱);
                        break;
                    case "-職稱":
                        data = data.OrderBy(s => s.職稱);
                        break;
                    case "+姓名":
                        data = data.OrderByDescending(s => s.姓名);
                        break;
                    case "-姓名":
                        data = data.OrderBy(s => s.姓名);
                        break;
                    case "+Email":
                        data = data.OrderByDescending(s => s.Email);
                        break;
                    case "-Email":
                        data = data.OrderBy(s => s.Email);
                        break;
                    case "+手機":
                        data = data.OrderByDescending(s => s.手機);
                        break;
                    case "-手機":
                        data = data.OrderBy(s => s.手機);
                        break;
                    case "+電話":
                        data = data.OrderByDescending(s => s.電話);
                        break;
                    case "-電話":
                        data = data.OrderBy(s => s.電話);
                        break;
                    default:
                        data = data.OrderByDescending(s => s.姓名);
                        break;
                }
            }
            else
                data = data.OrderByDescending(s => s.姓名);

            return View(data.ToPagedList(pageNo, 10));
        }

        // GET: 客戶聯絡人/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = repo.Find(id);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: 客戶聯絡人/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,客戶Id,職稱,姓名,Email,手機,電話")] 客戶聯絡人 客戶聯絡人)
        {
            if (ModelState.IsValid)
            {
                repo.Add(客戶聯絡人);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = repo.Find(id);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            return View(客戶聯絡人);
        }

        // POST: 客戶聯絡人/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,客戶Id,職稱,姓名,Email,手機,電話")] 客戶聯絡人 客戶聯絡人)
        {
            if (ModelState.IsValid)
            {
                repo.Modify(客戶聯絡人);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(客戶聯絡人);
        }

        // GET: 客戶聯絡人/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶聯絡人 客戶聯絡人 = repo.Find(id);
            if (客戶聯絡人 == null)
            {
                return HttpNotFound();
            }
            return View(客戶聯絡人);
        }

        // POST: 客戶聯絡人/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶聯絡人 客戶聯絡人 = repo.Find(id);
            repo.Delete(客戶聯絡人);
            repo.UnitOfWork.Commit();
            return RedirectToAction("Index");
        }

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
