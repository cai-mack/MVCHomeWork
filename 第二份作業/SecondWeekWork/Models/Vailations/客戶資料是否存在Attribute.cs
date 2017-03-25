using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SecondWeekWork.Models.Vailations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class 客戶資料是否存在Attribute : DataTypeAttribute
    {

        public 客戶資料是否存在Attribute() : base(DataType.Text)
        {
            ErrorMessage = "客戶Id不存在";
        }

        public override bool IsValid(object value)
        {
            int outI = 0;
            if (int.TryParse(value.ToString(), out outI)) return false;

            客戶資料Repository 客戶 = RepositoryHelper.Get客戶資料Repository();
            if (客戶.All().Count(s => s.Id == outI) == 0)
                return false;
            else
                return true;
            
        }
    }
}