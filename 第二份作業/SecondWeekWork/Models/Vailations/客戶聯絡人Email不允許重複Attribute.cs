using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SecondWeekWork.Models.Vailations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class 客戶聯絡人Email不允許重複Attribute : DataTypeAttribute
    {

        public 客戶聯絡人Email不允許重複Attribute() : base(DataType.Text)
        {
            ErrorMessage = "同客戶下客戶聯絡人Email不允許重複";
        }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            if (string.IsNullOrEmpty(str)) return true;

            客戶聯絡人Repository 聯絡人 = RepositoryHelper.Get客戶聯絡人Repository();
            List<string> list = new List<string>();
            聯絡人.All().Where(s => s.Email == str).ToList().ForEach(s=> list.Add(s.Id.ToString()));
            if (list.Distinct<String>().Count() != list.Count)
                return false;
            else
                return true;
            
        }
    }
}