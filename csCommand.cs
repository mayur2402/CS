using System;

class csCommand{
	public static void Main(string[] args){

		for(int i = 0;i < args.Length;i++){
			Console.WriteLine(args[i]);
		}
		Console.WriteLine(args.Length);
	}
}