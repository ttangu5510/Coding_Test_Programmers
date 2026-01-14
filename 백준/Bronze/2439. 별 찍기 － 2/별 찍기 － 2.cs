using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		int count = int.Parse(input);
		
		for(int i = 0 ; i < count ; i++)
		{
			for(int j = 0 ; j < count - i - 1 ; j++)
			{
				Console.Write(" ");
			}
			for(int j = 0 ; j < i + 1 ; j++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
