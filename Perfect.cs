/*
	Accept Number from user and check whether that number is perfect number or not
	input		= 12 -> (1+2+3+4+6) = 18
	output		= not perfect
	input 		= 6 -> (1+2+3) = 6
	output		= perfect
*/

using System;
namespace Slips
{
	class Perfect
	{
		int iNum = 0;
		Perfect(int iNum)
		{
			this.iNum = iNum;
		}
		int FactorAdd(int iNum)
		{
			int iAdd = 1,iCnt = 0;
			for(iCnt = iNum/2;iCnt >= 2;iCnt--)
			{
				if(iNum % iCnt == 0)
				{
					iAdd = iAdd + iCnt;
				}
				if(iAdd > iNum)
				{
					break;
				}
			}
			return iAdd;
		}
		bool ChkPerfect()
		{
			int iAdd = 0;
			if(this.iNum < 0)
			{
				this.iNum = -iNum;
			}
			if(this.iNum == 0 || this.iNum == 1)
			{
				return false;
			}
			iAdd = FactorAdd(this.iNum);
			if(iAdd == this.iNum)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		static void Main()
		{
			int iNum = 0;
			bool bIsPerfect = false;

			Console.WriteLine("\nEnter Number\t:");
			iNum = int.Parse(Console.ReadLine());

			Perfect Pobj = new Perfect(iNum);
			
			bIsPerfect = Pobj.ChkPerfect();
			if(bIsPerfect)
			{
				Console.WriteLine("{0} is Perfect number",iNum);
			}
			else
			{
				Console.WriteLine("{0} is not Perfect number",iNum);
			}
		}
	}
}
