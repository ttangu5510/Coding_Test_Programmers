using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		var inputNum = Console.ReadLine();
		if(string.IsNullOrEmpty(inputNum)) return;
		
		int count = int.Parse(input);
		int answer = 0;
		
		foreach(var c in inputNum)
		{
			answer += (int)c - '0';
		}
		
		Console.WriteLine(answer);
	}
}