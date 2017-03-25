using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace SecondWeekWork.Models
{
    public class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
    {
        internal 客戶資料 Find(int? id)
        {
            if (id.HasValue == false) return null;
            return this.All().FirstOrDefault(s => s.Id == id);

        }


        internal void Modify(客戶資料 客戶資料)
        {
            var db = this.UnitOfWork.Context;
            db.Entry(客戶資料).State = EntityState.Modified;
        }

        public override IQueryable<客戶資料> All()
        {
            return base.All().Where(s => false == s.IsDeleted);
        }

        public override void Delete(客戶資料 entity)
        {
            //base.Delete(entity);
            entity.IsDeleted = true;
        }

        public IQueryable<客戶資料> GetByFilter(string keyword, Object[] level)
        {
            var data = this.All();
            if (string.IsNullOrEmpty(keyword) == false)
            {
                data = data.Where(s => s.客戶名稱.Contains(keyword));
            }
            if (level != null && level.Count() > 0)
            {
                string str = level[0].ToString();
                data = data.Where(s => s.客戶分類.Contains(str));
            }

            return data;
        }
    }

    public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}