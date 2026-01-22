using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);
        int count = 0;
        int answer = 0;
		
		for(int i = 666 ; count < num ; i++)
		{
			string s = i.ToString();
			if(s.Contains("666")) count++;
            if(count == num) answer = i;
		}
		
		Console.WriteLine(answer);
	}
}
