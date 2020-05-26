using System;
namespace Online
{
	public class Overloading
	{
		public void Test()
		{
			Console.WriteLine("In public void Test()");
		}
		public void Test(int no)	//Overloading with different number of parameter
		{
			Console.WriteLine("In public void Test(int no)");
			Console.WriteLine(no);
		}
		public void Test(string name)	//Overloading with different type of parameter with 							same number of parameter
		{
			Console.WriteLine("In public void Test(string name)");
			Console.WriteLine(name);
		}
		public void Test(int no,string name)	//Overloading with different number of parameter
		{
			Console.WriteLine("In public void Test(int no,string name)");
			Console.WriteLine(no+" "+name);
		}
		public void Test(string name,int no)	//Overloading with different type of parameter with 								same number of parameter
		{
			Console.WriteLine("In public void Test(string name,int no)");
			Console.WriteLine(name+" "+no);
		}
		static void Main()
		{
			Overloading O=new Overloading();
			O.Test();
			O.Test(10);
			O.Test("Aniket");
			O.Test(20,"Devarshi");
			O.Test("Sagar",30);
		}
	}
}
