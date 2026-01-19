using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		int fac = 1;
		int div = 1;
		
		for(int i = nums[0] ; i > nums[1] ; i--)
		{
			fac *= i;
		}
		
		for(int i = 1 ; i <= nums[0] - nums[1] ; i++)
		{
			div *= i;
		}
		
		Console.WriteLine(fac / div);
	}
}