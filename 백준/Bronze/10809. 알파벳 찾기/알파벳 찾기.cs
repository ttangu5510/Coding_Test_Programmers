using System;

public class Test
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		for(int i = 'a' ; i <= 'z' ; i++)
		{
			Console.Write($"{input.IndexOf((char)i)} ");
		}
	}
}
