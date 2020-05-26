using System;
namespace Online
{
	public abstract class Math			// abstract class
	{
		public void Add(int x,int y)		//Non-abstract Method
		{
			Console.WriteLine(x+y);
		}
		public void Sub(int x,int y)		//Non-abstract Method
		{
			Console.WriteLine(x-y);
		}
		public abstract void Mul(int x,int y);	// abstract method
		public abstract void Div(int x,int y);	// abstract method
	}
	public class MathDemo : Math
	{
		public override void Mul(int x,int y)	//Implementing abstract method
		{
			Console.WriteLine(x * y);
		}
		public override void Div(int x,int y)	//Implementing abstract method
		{
			Console.WriteLine(x / y);
		}
		static void Main()
		{
			MathDemo M=new MathDemo();	//instance of child class

			M.Add(10,10);
			M.Sub(10,10);
			M.Mul(10,10);
			M.Div(10,10);

//			Math M=new Math();	//Cannot create an instance of the abstract class
			Math M1=M;		//creating reference of abstract class
			M1.Add(10,10);
			M1.Sub(10,10);
			M1.Mul(10,10);
			M1.Div(10,10);
		}
	}
}
