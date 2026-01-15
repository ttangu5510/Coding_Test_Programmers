using System;

public class Program
{
	public static void Main()
	{
		var inputA = Console.ReadLine();
		if(string.IsNullOrEmpty(inputA)) return;
			
		int a = int.Parse(inputA);
		
		var inputB = Console.ReadLine();
		if(string.IsNullOrEmpty(inputB)) return;
			
		int b = int.Parse(inputB);
		
		var inputC = Console.ReadLine();
		if(string.IsNullOrEmpty(inputC)) return;
			
		int c = int.Parse(inputC);
		int[] result = new int[10];
		
		long mul = a * b * c;
		foreach(var ch in mul.ToString())
		{
			result[ch - '0']++;
		}
		
		foreach(var n in result)
		{
			Console.WriteLine(n);
		}
		
	}
}
