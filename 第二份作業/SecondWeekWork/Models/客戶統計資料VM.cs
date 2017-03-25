using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondWeekWork.Models
{
    public class 客戶統計資料VM
    {
        public string 客戶名稱 { get; set; }
        public int 聯絡人數量 { get; set; }

        public int 銀行帳戶數量 { get; set; }

        public List<客戶統計資料VM> 客戶統計資料All()
        {
            List<客戶統計資料VM> lists = new List<客戶統計資料VM>();
            客戶資料Repository 客戶 = RepositoryHelper.Get客戶資料Repository();
            客戶聯絡人Repository 聯絡人 = RepositoryHelper.Get客戶聯絡人Repository();
            客戶銀行資訊Repository 銀行 = RepositoryHelper.Get客戶銀行資訊Repository();
            客戶統計資料VM entity;
            foreach (var item in 客戶.All())
            {
                entity = new 客戶統計資料VM();
                entity.客戶名稱 = item.客戶名稱;
                entity.聯絡人數量 = item.客戶聯絡人.Count;
                entity.銀行帳戶數量 = item.客戶銀行資訊.Count;
                //entity.聯絡人數量 = 聯絡人.All().Count(s => s.客戶Id == item.Id);
                //entity.銀行帳戶數量 = 銀行.All().Count(s => s.客戶Id == item.Id);
                lists.Add(entity);
            }
            return lists;
        }
    }

}