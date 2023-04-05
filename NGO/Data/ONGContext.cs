
using System.Data.Entity;


namespace NGO.Data
{
	public class ONGContext:DbContext
	{
		
		public DbSet<UserData> UserData { get; set; }
		public DbSet<FundData> FundData { get; set; }	
		public DbSet<FundNameData> FundNameData { get; set;}
		public DbSet<CategoryData> CategoryData { get; set; }
	}
}