using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		Console.WriteLine(Math.Ceiling((double)(nums[2] - nums[0]) / (nums[0] - nums[1])) + 1);
	}
}