using System;
namespace Online
{
	public class Overriding
	{
		public void Test()	//Method Overloading in same class
		{
			Console.WriteLine("In Poly public void Test(int no)");
		}
		public void Test(int i)	//Method Overloading in same class
		{
			Console.WriteLine("In Poly public void Test(int i)");
		}
		public virtual void Test1()	//Method Overridable
		{
			Console.WriteLine("In Poly public virtual void Test()");
		}
	}
	public class Overriding1 : Overriding
	{
		public void Test(string name)	//Method Overloading in parent-child class
		{
			Console.WriteLine("In Poly1 public void Test(string name)");
		}	
		public new void Test()	//Method Hiding
		{
			Console.WriteLine("In Poly1 public void Test(int no)");
		}
		public override void Test1()	//Method Overriding
		{
			Console.WriteLine("In Poly1 public override void Test()");
		}
		public void BaseTest()	//To access Methods of Parent Class Without creating instance of Parent
		{
			base.Test1();
			base.Test();
		}
		static void Main()
		{
			Console.WriteLine("Creating instance of child class");
			Overriding1 O=new Overriding1();
			O.Test();
			O.Test(10);
			O.Test("Baba");
			O.Test1();
			O.BaseTest();

			Console.WriteLine("Creating reference");
			Overriding o=O;
			o.Test();
			o.Test(10);
			o.Test1();
			 
		}
	}
}

