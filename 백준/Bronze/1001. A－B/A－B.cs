using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int[] nums = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        
        Console.WriteLine(nums[0] - nums[1]);
    }
}