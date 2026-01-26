using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		Stack<int> stack = new Stack<int>();
		
		for(int i = 0; i < count; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			int num = int.Parse(input);
			if(num == 0) stack.Pop();
			else stack.Push(num);
		}
		
		Console.WriteLine(stack.Sum());
	}
}