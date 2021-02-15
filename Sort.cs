using System;

class Sort{
	public static void Main(string[] args) {
		int len = args.Length;
		if(len == 1) {
			Console.WriteLine("Enter numbers to sort");
			Environment.Exit(-1);
		}
		int[] arr = new int[len];

		for (int i = 0;i < len;i++){
			arr[i] = int.Parse(args[i]);
		}
		for(int i = 0;i < len;i++) {
			Console.Write(arr[i]+"\t");
		}
		Console.WriteLine();
		Array.Sort(arr);
		for(int i = 0;i < len;i++) {
			Console.Write(arr[i]+"\t");
		}
		Console.WriteLine();
	}
}