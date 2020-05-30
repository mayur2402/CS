using System;
namespace Online
{
	class GenericDelegate
	{
		public int Add(int x,int y)
		{
			return x+y;
		}
		public void Sub(int x,int y)
		{
			Console.WriteLine(x-y);
		}
		public bool Check(int no)
		{
			if(no>0)
				return true;
			return false;
		}
		static void Main()
		{
			GenericDelegate G = new GenericDelegate();
			Func <int, int, int> obj = G.Add;	//for value returning method we can create delegate by using (Func<input types ,output type>) 
			int result = obj(10,20);
			Console.WriteLine(result);

			Action <int, int> obj1 = G.Sub;		//for non-value returning method we can create delegate by using (Action<input types>)
			obj1(20,19);

			Predicate <int> obj2 = G.Check;		//for Bool returning method we can create delegate by using (Predicate<input type>)
			bool b=obj2(2);
			if(b==true)
			{
				Console.WriteLine("Positive Number");
			}
			else
			{
				Console.WriteLine("Negative Number");
			}
		}
	}
}
