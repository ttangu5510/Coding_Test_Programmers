using System;
using System.Collections.Generic;

public class Program
{
	public static int ageBoundary = 200;
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		List<string>[] listArr = new List<string>[ageBoundary + 1];
		
		for(int i = 0 ; i < count ; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			int age = int.Parse(inputs[0]);
			
			// 나이를 인덱스로 사용
			if(listArr[age] == null)
			{
				listArr[age] = new List<string>();
			}
			listArr[age].Add(inputs[1]); // 이름 추가
		}
		
		for(int i = 0 ; i <= ageBoundary ; i++)
		{
			if(listArr[i] == null) continue;
			
			foreach(string s in listArr[i])
			{
				sw.WriteLine($"{i} {s}");
			}
		}
		
		sr.Close();
		sw.Close();
	}
}