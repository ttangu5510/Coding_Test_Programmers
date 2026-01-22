using System;

public class Program
{
	public static List<int> movieNum = new List<int>();
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);
		
		for(int i = 666 ; movieNum.Count <= 10000 ; i++)
		{
			string s = i.ToString();
			if(s.Contains("666")) movieNum.Add(i);
		}
		
		Console.WriteLine(movieNum[num - 1]);
	}
}
