using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int sum = 0;
		int astIndex = input.Length - 1;
		
		for(int i = 0 ; i < input.Length ; i++)
		{
			if(input[i] == '*')
			{ 
				astIndex = i;
				continue;
			}
			
			int digit = input[i] - '0';
			sum += i % 2 == 0 ? digit : 3 * digit;
		}
		
		sum %= 10;
		
		if(astIndex % 2 == 0)
		{
			for(int i = 0 ; i <=9 ; i++)
			{
				if(sum + i == 10)
				{
					Console.WriteLine(i);
					return;
				}
			}
		}
		else
		{
			for(int i = 0 ; i <= 9 ; i++)
			{
				if((sum + 3 * i) % 10 == 0)
				{
					Console.WriteLine(i);
					return;
				}
			}
		}
	}
}