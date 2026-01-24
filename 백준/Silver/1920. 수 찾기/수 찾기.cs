using System;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int nCount = int.Parse(input);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nNums = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		Array.Sort(nNums);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int mCount = int.Parse(input);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

		for(int i = 0; i < mCount; i++)
		{
			if(Array.BinarySearch(nNums, nums[i]) >= 0)	sw.WriteLine("1");
			else sw.WriteLine("0");
		}
		
		sr.Close();
		sw.Close();
	}
}
