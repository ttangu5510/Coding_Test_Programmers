using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
			
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		bool ascending = nums[0] == 1 && nums[1] == 2;
		bool descending = nums[0] == 8 && nums[1] == 7;
		string result = "";
		
		for(int i = 2 ; i < nums.Length - 1 ; i++)
		{
			if(!ascending && !descending) break;
			
			if(ascending && nums[i] + 1 != nums[i+1] )
			{
				ascending = false;
				break;
			}
			else if(descending && nums[i] - 1 != nums[i+1])
			{
				descending = false;
				break;
			}
		}
		
		if(ascending) result = "ascending";
		else if(descending) result = "descending";
		else result = "mixed";
		
		Console.WriteLine(result);
	}
}
