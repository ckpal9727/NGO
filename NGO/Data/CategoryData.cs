using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Data
{
	public class CategoryData:AuditClass
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsApproved { get; set; }
	}
}