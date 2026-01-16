using System;

public class Program
{
    public static void Main()
    {
        while(true)
        {
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input) || input == "0 0 0") return;
            
            int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            
            int maxIndex = 0;
            for(int i = 1 ; i < nums.Length ; i++)
            {
                if(nums[maxIndex] < nums[i]) maxIndex = i;
            }
            
            int sqrRest = 0;
            
            for(int i = 0 ; i < nums.Length ; i++)
            {
                if(i!=maxIndex) sqrRest += nums[i] * nums[i];
            }
            
            bool isRect = nums[maxIndex] * nums[maxIndex]  == sqrRest;
            Console.WriteLine(isRect? "right" : "wrong");
        }
    }
}