using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace SecondWeekWork.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        internal 客戶聯絡人 Find(int? id)
        {
            if (id.HasValue == false) return null;
            return this.All().FirstOrDefault(s => s.Id == id);

        }


        internal void Modify(客戶聯絡人 客戶聯絡人)
        {
            var db = this.UnitOfWork.Context;
            db.Entry(客戶聯絡人).State = EntityState.Modified;
        }

        public override IQueryable<客戶聯絡人> All()
        {

            return base.All().Where(s => false == s.IsDeleted);
        }

        public override void Delete(客戶聯絡人 entity)
        {
            //base.Delete(entity);
            entity.IsDeleted = true;

        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}