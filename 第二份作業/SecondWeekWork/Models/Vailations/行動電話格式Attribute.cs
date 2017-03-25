using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SecondWeekWork.Models.Vailations
{
    [AttributeUsage(AttributeTargets.Property)]
    public class 行動電話格式Attribute : DataTypeAttribute
    {

        public 行動電話格式Attribute() : base(DataType.Text)
        {
            ErrorMessage = "請輸入格式為0911-111111";
        }

        public override bool IsValid(object value)
        {
            string str = Convert.ToString(value);
            if (string.IsNullOrEmpty(str)) return true;

            Regex rgx = new Regex(@"\d{4}-\d{6}");

            return (rgx.IsMatch(str)) ? true : false;
        }
    }
}