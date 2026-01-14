using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		int count = int.Parse(input);
		StringBuilder sb = new StringBuilder();
		for(int i = 0 ; i < count ; i++)
		{
			for(int j = 0 ; j < count - i - 1 ; j++)
			{
				sb.Append(' ');
			}
			for(int j = 0 ; j < i + 1 ; j++)
			{
				sb.Append('*');
			}
			sb.AppendLine();
		}
        Console.WriteLine(sb.ToString());
	}
}
