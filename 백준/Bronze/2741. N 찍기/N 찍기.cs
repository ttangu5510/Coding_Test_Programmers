using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);
		StringBuilder sb = new StringBuilder();
		
		for(int i = 1 ; i <= num ; i++)
		{
			sb.AppendLine(i.ToString());
		}
		
		Console.WriteLine(sb.ToString());
	}
}