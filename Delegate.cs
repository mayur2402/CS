//Delegate is a type pointer which hold address of method
using System;
namespace Online
{
	public delegate void Add1(int x,int y);		//defining delegate for method Add
	public delegate string Say1(string str);	//defining delegate for method Say
	class Delegate
	{
		public void Add(int x,int y)
		{
			Console.WriteLine("Addition is "+(x+y));
		}
		public static string Say(string str)
		{
			return "Hello "+str;
		}
		static void Main()
		{
			Delegate d=new Delegate();	//instance of class Delegate
			Add1 A1=new Add1(d.Add);	//instance of delegate Add1 of non static method
			Say1 S1=new Say1(Delegate.Say);	//instance of delegate Say1 of static method
			A1(12,20);			//Call to the delegate Add1 
			string s=S1("Aniket");		//Call to the delegate Say1
			Console.WriteLine(s);
		}
	}
}
