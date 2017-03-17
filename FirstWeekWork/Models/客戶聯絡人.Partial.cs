namespace FirstWeekWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Vailations;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            客戶聯絡人Repository repo = RepositoryHelper.Get客戶聯絡人Repository();
            if (repo.All().Count(s => s.客戶Id == 客戶Id && s.Email == Email) > 0)
            {
                yield return new ValidationResult("同客戶下客戶聯絡人Email不允許重複");
            }
            else
            {
                yield return ValidationResult.Success;
            }
        }
    }

    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [客戶資料是否存在Attribute]
        public int 客戶Id { get; set; }

        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        [EmailAddress(ErrorMessage = "Email格式錯誤")]
        //[客戶聯絡人Email不允許重複Attribute("客戶Id")]
        public string Email { get; set; }
        
        [行動電話格式Attribute]
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }

    }
}
