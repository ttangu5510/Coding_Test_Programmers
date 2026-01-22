using System;

public class Program
{
	public static void Main()
	{
		int outNum = 0;
		
		for(int i = 0; i < 3 ; i++)
		{
			var input = Console.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			

			if(int.TryParse(input, out int num))
			{
				outNum = num + (3 - i);
				break;
			};
		}
		if(outNum % 3 == 0)
		{
			if(outNum % 5 == 0)
			{
				Console.WriteLine("FizzBuzz");
			}
			else
			{
				Console.WriteLine("Fizz");
			}
		}
		else if(outNum % 5 == 0)
		{
			Console.WriteLine("Buzz");
		}
		else
		{
			Console.WriteLine(outNum);
		}
	}
}