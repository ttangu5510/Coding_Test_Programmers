using System;
using System.Collections.Generic;

public class Program
{
	public static StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
	public static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
	
	public static void Main()
	{
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int caseCount = int.Parse(input);
		List<(int, int)> points = new List<(int, int)>();
		
		for(int i = 0; i < caseCount; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			string[] dot = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			points.Add((int.Parse(dot[0]), int.Parse(dot[1])));
		}
		
		points.Sort((a,b) => 
		{
			int result = a.Item2.CompareTo(b.Item2);
			if(result == 0) result = a.Item1.CompareTo(b.Item1);
			return result;
		});
		
		foreach(var p in points)
		{
			sw.WriteLine($"{p.Item1} {p.Item2}");
		}
		
		sr.Close();
		sw.Close();
	}
}