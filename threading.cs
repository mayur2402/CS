using System;
using System.Threading;
class threading
{
	static void Main(string[] args)
	{
		Thread T = Thread.CurrentThread;
		if(T.Name == null)
		{
			Console.WriteLine("Main Thread doesn't have name");
		}
		else
		{
			Console.WriteLine("Main Thread name is {0}"+T.Name);
		}
		T.Name = "Main";
		if(T.Name == null)
		{
			Console.WriteLine("Main Thread doesn't have name");
		}
		else
		{
			Console.WriteLine("Main Thread name is "+T.Name);
		}
	}
}
