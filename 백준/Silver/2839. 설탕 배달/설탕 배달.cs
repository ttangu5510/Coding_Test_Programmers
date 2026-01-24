using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int n = int.Parse(input);
		
		int div = n / 5;
		
		for(int i = div; i >= 0; i--)
		{
			int left = n - 5 * i;
			
			if (left % 3 == 0)
			{
				Console.WriteLine( i + left / 3);
				return;
			}
		}
		Console.WriteLine(-1);
	}
}