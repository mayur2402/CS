//insteed of creating method and then delegate we can directly create anonymous delegate
using System;
namespace Online
{
	public delegate string Greeting(string name);	//defining delegate
	class Greet
	{
		static void Main()
		{
			Greeting obj=delegate(string name)	//creating delegate to a non method body
			{
				return "Good Morning "+name;
			};
			string str=obj("Sagar");
			Console.WriteLine(str);
		}
	}
}
