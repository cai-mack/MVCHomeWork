using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecondWeekWork.Models;

namespace SecondWeekWork.Controllers
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

    }
}
