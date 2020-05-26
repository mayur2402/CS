using System;
namespace Online
{
	public class Access
	{
		public int a;
		public const int b=10;
		public static int c=100;
		public readonly int d;
		public Access()
		{
			this.a=0;
	//		this.b=0;  Constant value can't be change after it's declaration
	//		this.c=0;  Static variable can't be access with instace(object) of class
			this.d=0;
		}
		public Access(int a,int b,int c,int d)
		{
			this.a=a;
	//		this.b=b;  Constant value can't be change after it's declaration
	//		this.c=c;  Static variable can't be access with instace(object) of class
			this.d=d;
		}
		private void Test1()
		{
			Console.WriteLine("In Private");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine("c="+c);
			Console.WriteLine("d="+d);
		}
		protected void Test2()
		{
			Console.WriteLine("In Protected");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine("c="+c);
			Console.WriteLine("d="+d);
		}
		protected internal void Test3()
		{
			Console.WriteLine("In Protected Internal");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine("c="+c);
			Console.WriteLine("d="+d);
		}
		internal void Test4()
		{
			Console.WriteLine("In Internal");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine("c="+c);
			Console.WriteLine("d="+d);
		}
		public void Test5()
		{
			Console.WriteLine("In Public");
			Console.WriteLine("a="+a);
			Console.WriteLine("b="+b);
			Console.WriteLine("c="+c);
			Console.WriteLine("d="+d);
		}
	}
	class Access1 : Access
	{
		static void Main()
		{
			Console.WriteLine("In Main of Child using default of child");
			Access1 A=new Access1();
//			A.Test1();  is inaccessible due to its protection level
			A.Test2();
			A.Test3();
			A.Test4();
			A.Test5();

			A.a=30;
//			A.b=30;  Constant value can't be change after it's declaration
//			A.c=30;  Static variable can't be access with instace(object) of class
//			A.d=30;  for readonly variable we can't assign value after it's declaration or initialization

			Console.WriteLine("A.a="+A.a);
			Console.WriteLine("A.d="+A.d);

			Console.WriteLine("In Main of Child using Parameterized of parent");
			Access AS1=new Access(40,20,30,40);
//			AS1.Test1();  is inaccessible due to its protection level
//			AS1.Test2();  protected access specifier method require class constructor to call
			AS1.Test3();
			AS1.Test4();
			AS1.Test5();
			
			AS1.a=60;
			
			Console.WriteLine("AS1.a="+AS1.a);
		}
	}
}
