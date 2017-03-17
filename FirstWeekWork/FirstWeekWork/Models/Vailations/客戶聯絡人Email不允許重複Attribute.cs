using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FirstWeekWork.Models.Vailations
{
    /*
     * 未能實現多參數輸入
     */

    [AttributeUsage(AttributeTargets.Property)]
    public class 客戶聯絡人Email不允許重複Attribute : DataTypeAttribute
    {
        string 客戶Id;

        public 客戶聯絡人Email不允許重複Attribute(string _客戶Id) : base(DataType.Text)
        {
            客戶Id = _客戶Id;
            ErrorMessage = "同客戶下客戶聯絡人Email不允許重複";
        }



        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            if (string.IsNullOrEmpty(str)) return true;

            客戶聯絡人Repository 聯絡人 = RepositoryHelper.Get客戶聯絡人Repository();
            List<string> list = new List<string>();
            聯絡人.All().Where(s => s.Email == str).ToList().ForEach(s => list.Add(s.客戶Id.ToString()));
            if (list.Distinct<String>().Count() != list.Count)
                return false;
            else
                return true;

        }
    }
}