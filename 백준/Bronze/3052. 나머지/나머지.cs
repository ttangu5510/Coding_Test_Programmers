using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		List<int> remain = new List<int>();
		
		for(int i = 0 ; i < 10 ; i++)
		{
			var input = Console.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			int num = int.Parse(input) % 42;
			if(!remain.Contains(num)) remain.Add(num);
		}
		Console.WriteLine(remain.Count);
	}
}
