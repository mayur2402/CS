using System;
using System.Threading;
class Output
{
	public void Test()
	{
		Console.WriteLine("Name = "+Thread.CurrentThread.Name);
		for(int iCnt = 1;iCnt <= 10;iCnt++)
		{
			Console.WriteLine(Thread.CurrentThread.Name+"\t"+iCnt);
			Thread.Sleep(1000);
		}
	}
}
class MultiThreading
{
	static void Main()
	{
		Thread.CurrentThread.Name = "main";
		Console.WriteLine("Name = "+Thread.CurrentThread.Name);
		
		Output obj = new Output();

		Thread T1 = new Thread(obj.Test);
		T1.Name = "Thread1";

		Thread T2 = new Thread(obj.Test);
		T2.Name = "Thread2";

		T1.Start();
		T2.Start();
	}
}
