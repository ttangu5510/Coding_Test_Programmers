using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);

		Console.WriteLine(num / 125 + num / 25 + num / 5);
	}
}