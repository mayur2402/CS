using System;
using System.IO;
class CsFile
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter File name");
		string name = Console.ReadLine();

		StreamWriter SW = new StreamWriter(name);

		Console.WriteLine("Enter Data to store in file");
		string Adata = Console.ReadLine();

		using(SW)
		{
			SW.WriteLine(Adata);
		}

		StreamReader SR = new StreamReader(name);
		using(SR)
		{
			string Ddata = SR.ReadLine();
			Console.WriteLine(Ddata);
		}

	}
}
