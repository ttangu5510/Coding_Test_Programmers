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
		
		Console.WriteLine(a + b - c);
		Console.WriteLine(int.Parse(a.ToString() + b.ToString()) - c);
	}
}
