using System;
using System.Text;
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
		
		int n = int.Parse(input);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nCard = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int m = int.Parse(input);
		
		input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] mCard = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		StringBuilder sb = new StringBuilder();
		Dictionary<int, int> dict = new Dictionary<int, int>();
		
		for(int i = 0; i < n; i++)
		{
			if(!dict.ContainsKey(nCard[i])) dict.Add(nCard[i], 1);
			else dict[nCard[i]]++;
		}
		for(int i = 0; i < m; i++)
		{
			if(dict.ContainsKey(mCard[i])) sb.Append($"{dict[mCard[i]]} ");
			else sb.Append("0 ");
		}
		
		sw.Write(sb);
		
		sr.Close();
		sw.Close();
	}
}
