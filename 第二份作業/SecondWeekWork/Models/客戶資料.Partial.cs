namespace SecondWeekWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Vailations;

    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
        
        //public SelectList 客戶分類SelectList = new SelectList(
        //                          new List<Object>{
        //                               new { value = 0 , text = "高"  },
        //                               new { value = 1 , text = "中" },
        //                               new { value = 2 , text = "低"}
        //                            },
        //                          "value",
        //                          "text",
        //                           2);
    }
    
    public partial class 客戶資料MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        
        [StringLength(8, ErrorMessage="欄位長度不得大於 8 個字元")]
        [Required]
        public string 統一編號 { get; set; }
        

        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        [行動電話格式Attribute]
        public string 電話 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 傳真 { get; set; }
        
        [StringLength(100, ErrorMessage="欄位長度不得大於 100 個字元")]
        public string 地址 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [EmailAddress(ErrorMessage = "Email格式錯誤")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "欄位長度不得大於 20 個字元")]
        public string 客戶分類 { get; set; }



        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
