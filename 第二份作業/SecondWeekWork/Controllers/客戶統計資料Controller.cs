using SecondWeekWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SecondWeekWork.Controllers
{
    public class 客戶統計資料Controller : Controller
    {
        // GET: 客戶統計資料
        public ActionResult Index()
        {
            var db = new 客戶統計資料VM();
            return View(db.客戶統計資料All());
        }
    }
}
