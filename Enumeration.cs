using System;
namespace Online
{
	public enum Days
	{
		Monday,Tuesday,Wednesday,Thursday,Friday
	}
	class Enumeration
	{
		public static Days Meeting { get;set; } = (Days).0; // or Days.Monday
		static void Main()
		{
			Console.WriteLine(Meeting);
		//	Meeting = Days.Saturday;  `Online.Days' does not contain a definition for `Saturday'
			Meeting = Days.Friday;
			Console.WriteLine(Meeting);
		}
	}
}
