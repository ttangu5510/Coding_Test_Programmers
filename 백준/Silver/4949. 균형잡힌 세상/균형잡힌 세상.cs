using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		while(true)
		{
			var input = Console.ReadLine();
			if(string.IsNullOrEmpty(input) || input == ".") return;
			
			Stack<char> br = new Stack<char>();
			
			bool hasBr = true;
			
			for(int i = 0; i < input.Length; i++)
			{
				
				switch(input[i])
				{
					case '(':
						br.Push('(');
						break;
					case '[':
						br.Push('[');
						break;
					case ')':
						if(br.Count == 0 || br.Pop() != '(')
						{
							hasBr = false;
						}
						break;
					case ']':
						if(br.Count == 0 || br.Pop() != '[')
						{
							hasBr = false;
						}
						break;
				}
				if(!hasBr) break;
			}
			if(hasBr && br.Count == 0) Console.WriteLine("yes");
            else Console.WriteLine("no");
		}
	}
}
