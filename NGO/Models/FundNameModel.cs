using NGO.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Models
{
	public class FundNameModel
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int limit { get; set; }
		public DateTime TargetReachDate { get; set; }
		public string FundId { get; set; }
		public virtual FundData Fund { get; set; }
	}
}