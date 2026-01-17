using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int n = int.Parse(input);
		
		int log = (int)Math.Log10(n) + 1;
		int min = n - 10 * log;
		
		for(int i = min ; i < n ; i++)
		{
			int result = i;
			int val = i;
			for(int j = 0 ; j <= log ; j++)
			{
				result += val % 10;
				val /= 10;
			}
			if(result == n)
			{
				Console.WriteLine(i);
				return;
			}
		}
		Console.WriteLine(0);
	}
}
