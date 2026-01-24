using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
        StringBuilder sb = new StringBuilder();
		Stack<char> br = new Stack<char>();
		bool hasBr;
		
		while(true)
		{
			var input = sr.ReadLine();
			if(string.IsNullOrEmpty(input) || input == ".") break;
			
			br.Clear();
			hasBr = true;
			
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
			
			if(hasBr && br.Count == 0) sb.AppendLine("yes");
			else sb.AppendLine("no");
		}
		
        sw.Write(sb);
        
        sr.Close();
        sw.Close();
	}
}