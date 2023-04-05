using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Data
{
	public class FundData:AuditClass
	{
		public string Id { get; set; }
		public int Money { get; set; }
		public string UserId { get; set; }
		public string FundId { get; set; }
		public virtual UserData UserData { get; set; }
		public virtual FundNameData FundName { get; set; }
	}
}