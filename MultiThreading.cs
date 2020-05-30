using System;
using System.Threading;
class MultiThreading
{
	static void Test1()
	{
		for(int i=0;i<100;i++)
		{
			Console.WriteLine("Test1 "+i);
		}
	}
	static void Test2()
	{
		for(int i=0;i<100;i++)
		{
			Console.WriteLine("Test2 "+i);
			if(i==50)
			{
				Console.WriteLine("Thread2 Stop");
				Thread.Sleep(10000);
				Console.WriteLine("Thread2 Start");
			}
		}
	}
	static void Test3()
	{
		for(int i=0;i<100;i++)
		{
			Console.WriteLine("Test3 "+i);
		}
	}
	static void Main()
	{
		Thread T1 = new Thread(Test1);
		Thread T2 = new Thread(Test2);
		Thread T3 = new Thread(Test3);
		T1.Start();
		T2.Start();
		T3.Start();
	}
}
