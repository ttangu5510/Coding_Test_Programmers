using System;
using System.Collections.Generic;

public class Program
{
	public static Dictionary<(int, int), long> facDict = new Dictionary<(int, int), long>();
	
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		
		for(int i = 0 ; i < count ; i++)
		{
			input = sr.ReadLine();
			int k = int.Parse(input);
			
			input = sr.ReadLine();
			int n = int.Parse(input);
			
			sw.WriteLine(Sum(k, n));
		}
		
		sr.Close();
		sw.Close();
	}
	
	// 재귀 함수로 구현
	public static long Sum(int a, int b)
	{
		if(a == 0) return b;
		
		if(!facDict.TryGetValue((a, b), out long result))
		{
			for(int i = 1 ; i <= b ; i++)
			{
				result += Sum(a - 1, i);
			}
			facDict.Add((a, b), result);
		}
		
		return result;
	}
}