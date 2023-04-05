using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NGO.Data
{
	public class UserData:AuditClass
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Mobile { get; set; }
	}
}