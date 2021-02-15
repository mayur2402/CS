using System;

class Table {
	public static void Main(string[] args){
		try{
			if(args.Length != 1){
				Console.WriteLine("Enter only one argument");
				Environment.Exit(-1);
			}

			int num = int.Parse(args[0]);

			for(int i = 1;i <= 10;i++) {
				Console.WriteLine(i * num);
			}
		}
		catch(FormatException fe){
			Console.WriteLine("Enter valid number",fe);
		}
		
	}
}