using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Data
{
	public class AuditClass
	{
		public DateTime CreatedAt { get; set; }
		public string CreatedBy { get; set; }

		public DateTime UpdatedAt { get; set;}
		public string UpdatedBy { get; set;}
	}
}