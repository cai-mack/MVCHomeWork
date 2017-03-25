using System;
using System.Linq;
using System.Collections.Generic;
	
namespace SecondWeekWork.Models
{   
	public  class 客戶彙整資料ExRepository : EFRepository<客戶彙整資料Ex>, I客戶彙整資料ExRepository
	{
    }

	public  interface I客戶彙整資料ExRepository : IRepository<客戶彙整資料Ex>
	{

	}
}