using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int n = int.Parse(input);
		int[] pCounter = new int[1000001];
		int[] nCounter = new int[1000001];
		
		// 배열에 담기
		for(int i = 0 ; i < n ; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) break;
			
			int num = int.Parse(input);
			
			if(num < 0) nCounter[-num]++;
			else pCounter[num]++;
		}
		
		// 음수 출력
		for(int i = nCounter.Length - 1 ; i > 0; i--)
		{
			if(nCounter[i] == 0) continue;
			
			for(int j = 0 ; j < nCounter[i] ; j++)
				sw.WriteLine(-i);
		}
		
		// 양수 출력
		for(int i = 0 ; i < pCounter.Length ; i++)
		{
			if(pCounter[i] == 0) continue;
			
			for(int j = 0 ; j < pCounter[i] ; j++)
				sw.WriteLine(i);
		}
		
		sr.Close();
		sw.Close();
	}
}
