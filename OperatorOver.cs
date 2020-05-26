using System;
namespace online
{
	public class Matrix
	{
		public int a,b,c,d;
		public Matrix(int a,int b,int c,int d)
		{
			this.a=a;
			this.b=b;
			this.c=c;
			this.d=d;
		}
		public static Matrix operator +(Matrix obj1,Matrix obj2)
		{
			Matrix obj=new Matrix(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
			return obj;
		}
//		public virtual string ToString() internally declare like this hence we can override and change the O/P so
		public override string ToString()//if we does not override we get name of class as O/P.
		{
			return a+" "+b+"\n"+c+" "+d+"\n";
		}
	}
	class TestMatrix
	{
		static void Main()
		{
			Matrix M1=new Matrix(20,18,16,14);
			Matrix M2=new Matrix(10,8,6,4);
//			Matrix M3=new Matrix(M1.a+M2.a,M1.b+M2.b,M1.c+M2.c,M1.d+M2.d);this is to lengthy method
			Matrix M3=M1+M2;
			Console.WriteLine(M1);
			Console.WriteLine(M2);
			Console.WriteLine(M3);
		}
	}
}
