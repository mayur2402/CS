using System;
namespace Online
{
	interface Math	//creating interface which contain only abstract methods
	{
		void Add(int x,int y);	//abstract meethod
		void Sub(int x,int y);	//abstract meethod
		void Mul(int x,int y);	//abstract meethod
		void Div(int x,int y);	//abstract meethod 
	}
	public class Interface : Math
	{
		public void Add(int x,int y)	//implementing logic to abstract method without override
		{
			Console.WriteLine(x + y);
		}
		public void Sub(int x,int y)
		{
			Console.WriteLine(x - y);
		}
		public void Mul(int x,int y)
		{
			Console.WriteLine(x * y);
		}
		public void Div(int x,int y)
		{
			Console.WriteLine(x / y);
		}
		static void Main()
		{
			Interface I=new Interface();
			I.Add(10,10);
			I.Sub(10,10);
			I.Mul(10,10);
			I.Div(10,10);

			Math M=I;	//using reference of interface
			M.Add(20,10);
			M.Sub(20,10);
			M.Mul(20,10);
			M.Div(20,10);
		}
	}
}
