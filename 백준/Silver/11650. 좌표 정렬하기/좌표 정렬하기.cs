using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		List<(int, int)> coordList = new List<(int, int)>();
		
		for(int i = 0 ; i < count ; i++)
		{
			input = sr.ReadLine();
			int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
			coordList.Add((nums[0], nums[1]));
		}
		coordList.Sort((x, y) => 
		{
			int result = x.Item1.CompareTo(y.Item1);
			if(result == 0) result = x.Item2.CompareTo(y.Item2);
			return result;
		});
		foreach(var l in coordList)
		{
			sw.WriteLine($"{l.Item1} {l.Item2}");
		}
		
		sr.Close();
		sw.Close();
	}
}