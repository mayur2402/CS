using System;
namespace Online
{
	public delegate void RectDelegate(double length,double breadth);	//Multicasting delegete defining a single delegate for multiple method 
	class Rectangle
	{
		public void Area(double length,double breadth)
		{
			Console.WriteLine("Area of rectangle is "+(length*breadth));
		}
		public void Perimeter(double length,double breadth)
		{
			Console.WriteLine("Perimeter of rectangle is "+(2*(length+breadth)));
		}
		static void Main()
		{
			Rectangle R = new Rectangle();
			RectDelegate R1 = R.Area;	//Creating instance of delegete without new keyword
			R1 = R1 + R.Perimeter;		//just give the name of method without using ()
			R1.Invoke(22.22,34.89);	//R1.(22.22,34.89); is also used
		}
	}
}
