using System;

public class Program
{
    public static void Main()
    {
        while(true)
        {
        	var input = Console.ReadLine();
        	if(string.IsNullOrEmpty(input)) return;
        	
        	int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
        	if(nums[0] == 0 && nums[1] == 0) return;
        	Console.WriteLine(nums[0] + nums[1]);
        }
    }
}