using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace SecondWeekWork.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        internal 客戶銀行資訊 Find(int? id)
        {
            if (id.HasValue == false) return null;
            return this.All().FirstOrDefault(s => s.Id == id);

        }


        internal void Modify(客戶銀行資訊 客戶銀行資訊)
        {
            var db = this.UnitOfWork.Context;
            db.Entry(客戶銀行資訊).State = EntityState.Modified;
        }

        public override IQueryable<客戶銀行資訊> All()
        {

            return base.All().Where(s => s.IsDeleted == false);
        }

        public override void Delete(客戶銀行資訊 entity)
        {
            //base.Delete(entity);
            entity.IsDeleted = true;

        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}