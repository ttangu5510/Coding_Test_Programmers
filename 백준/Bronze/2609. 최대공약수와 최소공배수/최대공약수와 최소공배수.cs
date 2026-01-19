using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		Console.WriteLine(GCD(nums[0], nums[1]));
		Console.WriteLine(LCM(nums[0], nums[1]));
	}
	public static int GCD(int a, int b)
	{
		int r = a % b;
		if(r == 0) return b;
		return GCD(b, r);
	}
	public static int LCM(int a, int b) => a * b / GCD(a, b);
}