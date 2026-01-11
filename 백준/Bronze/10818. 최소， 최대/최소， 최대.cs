using System;

public class Program
{
    public static void Main()
    {
        var inputCount = Console.ReadLine();
        if(string.IsNullOrEmpty(inputCount)) return;
        
        int count = int.Parse(inputCount);
        
        var inputArr = Console.ReadLine();
        if(string.IsNullOrEmpty(inputArr)) return;
        
        int[] nums = Array.ConvertAll(inputArr.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        if(nums.Length != count) return;
        
        int maxNum = int.MinValue;
        int minNum = int.MaxValue;
        
        for(int i = 0 ; i < nums.Length;i++)
        {
            if(nums[i] > maxNum)
                maxNum = nums[i];
            if(minNum > nums[i])
                minNum = nums[i];
        }
        
        Console.WriteLine($"{minNum} {maxNum}");
    }
}