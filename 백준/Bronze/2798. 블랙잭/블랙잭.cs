using System;
 
public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
 
		int[] condition = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
 
		input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
 
		int[] cards = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
 
		int minDiff = int.MaxValue;
		int result = 0;
 
		for(int i = 0 ; i < condition[0] - 2; i++)
		{
			for(int j = i + 1 ; j < condition[0] - 1; j++)
			{
				int sum = cards[i] + cards[j];
				for(int k = j + 1 ; k < condition[0] ; k++)
				{
					int curSum = sum + cards[k];
					int diff = condition[1] - curSum;
					if(diff >= 0 && diff < minDiff)
					{
						minDiff = diff;
						result = curSum;
					}
				}
			}
		}
		Console.WriteLine(result);
	}
}