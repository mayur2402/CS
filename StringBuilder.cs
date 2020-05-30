using System;
using System.Text;
using System.Diagnostics;
namespace Online
{
	class StringBuilder1
	{
		static void Main()
		{
			Stopwatch sw1=new Stopwatch();
			string s=" ";
			sw1.Start();
			for(int i=0;i<10000;i++)
			{
				s=s+i;
			}
			sw1.Stop();
			StringBuilder sb=new StringBuilder();
			Stopwatch sw2=new Stopwatch();
			sw2.Start();
			for(int i=0;i<10000;i++)
			{
				sb.Append(i);
			}
			sw2.Stop();
			Console.WriteLine(sw1.ElapsedMilliseconds);
			Console.WriteLine(sw2.ElapsedMilliseconds);
		}
	}
}
