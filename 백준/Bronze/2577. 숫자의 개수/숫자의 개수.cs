using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
			
		int a = int.Parse(input);
		
		input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
			
		int b = int.Parse(input);
		
		input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
			
		int c = int.Parse(input);
        
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
