using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		Stack<char> stack = new Stack<char>();
		
		for(int i = 0; i < count; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			bool hasPass = true;
			stack.Clear();
			
			foreach(char c in input)
			{
				switch(c)
				{
					case ')':
						if(!(stack.Count > 0 && stack.Pop() == '(')) hasPass = false;
						break;
					case '(':
						stack.Push(c);
						break;
				}
				if(!hasPass) break;
			}
			
			if(hasPass && stack.Count == 0) sw.WriteLine("YES");
			else sw.WriteLine("NO");
		}
		
		sr.Close();
		sw.Close();
	}
}