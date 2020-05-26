using System;
namespace Online
{
	public struct Structure
	{
//		int i=10;	Structs cannot have instance property or field initializers
		int i;
		public Structure(int i)
		{
			this.i=i;
		}
		public void Show()
		{
			Console.WriteLine("In Structure method "+i);
		}
		static void Main()
		{
			Structure s1=new Structure(10);
			Structure s2;	//We can create instance without using new keyword
			s2.i=20;
			s1.Show();
			s2.Show();
		}
	}
}
