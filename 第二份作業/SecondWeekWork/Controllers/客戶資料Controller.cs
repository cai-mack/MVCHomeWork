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
    public class 客戶資料Controller : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        客戶資料Repository repo = RepositoryHelper.Get客戶資料Repository();

        // GET: 客戶資料
        public ActionResult Index(string keyword, Object[] level, string sortBy, int pageNo = 1)
        {
            var data = repo.GetByFilter(keyword, level);
            //var data = repo.All();
            //if (string.IsNullOrEmpty(keyword) == false)
            //{
            //    data = data.Where(s => s.客戶名稱.Contains(keyword));
            //}
            //if (level != null && level.Count() > 0)
            //{
            //    string str = level[0].ToString();
            //    data = data.Where(s => s.客戶分類.Contains(str));
            //}
            ViewBag.keyword = keyword;
            ViewBag.level = level;
            ViewBag.sortBy = sortBy;
            ViewBag.pageNo = pageNo;

            if (string.IsNullOrEmpty(sortBy) == false)
            {
                switch (sortBy)
                {
                    case "+客戶分類":
                        data = data.OrderByDescending(s => s.客戶分類);
                    break;
                    case "-客戶分類":
                        data = data.OrderBy(s => s.客戶分類);
                        break;
                    case "+客戶名稱":
                        data = data.OrderByDescending(s => s.客戶名稱);
                        break;
                    case "-客戶名稱":
                        data = data.OrderBy(s => s.客戶名稱);
                        break;
                    case "+統一編號":
                        data = data.OrderByDescending(s => s.統一編號);
                        break;
                    case "-統一編號":
                        data = data.OrderBy(s => s.統一編號);
                        break;
                    case "+電話":
                        data = data.OrderByDescending(s => s.電話);
                        break;
                    case "-電話":
                        data = data.OrderBy(s => s.電話);
                        break;
                    case "+傳真":
                        data = data.OrderByDescending(s => s.傳真);
                        break;
                    case "-傳真":
                        data = data.OrderBy(s => s.傳真);
                        break;
                    case "+地址":
                        data = data.OrderByDescending(s => s.地址);
                        break;
                    case "-地址":
                        data = data.OrderBy(s => s.地址);
                        break;
                    case "+Email":
                        data = data.OrderByDescending(s => s.Email);
                        break;
                    case "-Email":
                        data = data.OrderBy(s => s.Email);
                        break;
                    default:
                        data = data.OrderByDescending(s => s.客戶名稱);
                        break;
                }
            }                
            else
                data = data.OrderByDescending(s => s.客戶名稱);

            return View(data.ToPagedList(pageNo,10));
        }

        // GET: 客戶資料/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶資料 客戶資料 = repo.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // GET: 客戶資料/Create
        public ActionResult Create()
        {
            //List<SelectListItem> selectItemList = new List<SelectListItem>();
            //selectItemList.Add(new SelectListItem() { Text = "高", Value = "高" });
            //selectItemList.Add(new SelectListItem() { Text = "中", Value = "中", Selected = true, });
            //selectItemList.Add(new SelectListItem() { Text = "低", Value = "低" });

            //ViewData["客戶分類List"] = selectItemList;


            return View();
        }

        // POST: 客戶資料/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(客戶資料 客戶資料)
        {

            if (ModelState.IsValid)
            {
                repo.Add(客戶資料);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(客戶資料);
        }

        // GET: 客戶資料/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶資料 客戶資料 = repo.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // POST: 客戶資料/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(客戶資料 客戶資料)
        {

            if (ModelState.IsValid)
            {
                repo.Modify(客戶資料);
                repo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(客戶資料);
        }

        // GET: 客戶資料/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            客戶資料 客戶資料 = repo.Find(id);
            if (客戶資料 == null)
            {
                return HttpNotFound();
            }
            return View(客戶資料);
        }

        // POST: 客戶資料/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            客戶資料 客戶資料 = repo.Find(id);
            repo.Delete(客戶資料);
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
