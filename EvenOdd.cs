using System;
namespace predict_output
{
	class Difference
	{
		public int Display(int[] iArr,int iNo)
		{
			int iAns = 0;
			for(int iCnt = 0;iCnt < iNo;iCnt++)
			{
				if(iArr[iCnt] % 2 == 0)
				{
					iAns =  iAns + iArr[iCnt];
				}
				else
				{
					iAns =  iAns - iArr[iCnt];
				}
			}
			return iAns;
		}
	}
	class EvenOdd
	{
		public static void Main()
		{
			Console.WriteLine("\nHow many numbers\t");
			int iNo = int.Parse(Console.ReadLine());
			int[] iArr = new int[iNo];
			Console.WriteLine("Enter Numbers");
			for(int iCnt = 0;iCnt < iNo;iCnt++)
			{
				iArr[iCnt] = int.Parse(Console.ReadLine());
			}
			Difference dObj = new Difference();
			int iDiff = dObj.Display(iArr,iNo);
			Console.WriteLine("Difference between even elements and odd elements are {0}",iDiff);
		}
	}
}
