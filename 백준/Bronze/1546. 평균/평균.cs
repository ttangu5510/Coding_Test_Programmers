using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		
		input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] scores = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		int best = scores[0];
		int sum = 0;
		foreach(int n in scores)
		{
			sum += n;
			if(n > best) best = n;
		}
		
		Console.WriteLine((float)sum / (best * count) * 100);
	}
}