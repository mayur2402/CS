using System;
class CheckLCM
{
	public int iNo1 = 0,iNo2 = 0;
	public CheckLCM(int i,int j)
	{
		this.iNo1 = i;
		this.iNo2 = j;
	}
	public int ChkLCM()
	{
		int iNum = 0;
		if(this.iNo1 == 0 && this.iNo2 == 0)
		{
			Environment.Exit(-1);
		}
		if(this.iNo1 < 0)
		{
			this.iNo1 = -this.iNo1;
		}
		if(this.iNo2 < 0)
		{
			this.iNo2 = -this.iNo2;
		}
		if(this.iNo1 < this.iNo2)
		{
			iNum = this.iNo1;
		}
		else
		{
			iNum = this.iNo2;
		}
		while(true)
		{
			if((iNum % this.iNo1 == 0) && (iNum % this.iNo2 == 0))
			{
				break;
			}
			iNum++;
		}
		return iNum;
	}
}
class LCM
{
	public static void Main(string[] args)
	{
		int iNo1 = 0,iNo2 = 0;
		try
		{
			Console.WriteLine("Enter First Number");
			iNo1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Second Number");
			iNo2 = int.Parse(Console.ReadLine());
		}
		catch(FormatException FE)
		{
			Console.WriteLine(FE.Message);
		}

		CheckLCM lobj = new CheckLCM(iNo1,iNo2);
		int iAns = lobj.ChkLCM();

		Console.WriteLine("LCM of {0} and {1} is {2}",iNo1,iNo2,iAns);
	}
}
