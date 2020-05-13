using System;
using static System.Random;
using System.Text;
class PasswordGenerator
{
	private const string capitalletter="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	private const string smallletter="abcdefghijklmnopqrstuvwxyz";
	private const string number="0123456789";
	private const string specialcharacter="~!@#$%^&*?|><";
	private const string all=capitalletter+smallletter+number+specialcharacter;
	
	private static Random rand=new Random();
	
	static void Main()
	{
		StringBuilder password=new StringBuilder();

		for(int i=1;i<=2;i++)
		{
			char capital=GenerateChar(capitalletter);
			InsertAtRandomPosition(password,capital);
		}

		for(int i=1;i<=2;i++)
		{
			char small=GenerateChar(smallletter);
			InsertAtRandomPosition(password,small);
		}

		char digit=GenerateChar(number);
		InsertAtRandomPosition(password,digit);
		
		for(int i=1;i<=3;i++)
		{
			char special=GenerateChar(specialcharacter);
			InsertAtRandomPosition(password,special);
		}

		int count=rand.Next(8);

		for(int i=1;i<=count;i++)
		{
			char pass=GenerateChar(all);
			InsertAtRandomPosition(password,pass);
		}

		Console.WriteLine(password);
	}

	private static void InsertAtRandomPosition(StringBuilder password,char character)
	{
		int position=rand.Next(password.Length+1);
		password.Insert(position,character);
	}

	private static char GenerateChar(string generate)
	{
		int position=rand.Next(generate.Length);
		char found=generate[position];
		return found;
	}
}
