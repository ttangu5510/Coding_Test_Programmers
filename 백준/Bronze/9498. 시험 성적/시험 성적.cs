using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);
		char answer;
		if(num >= 90) answer = 'A';
		else if(num >= 80) answer = 'B';
		else if(num >= 70) answer = 'C';
		else if(num >= 60) answer = 'D';
		else answer = 'F';
		
		Console.WriteLine(answer);
	}
}