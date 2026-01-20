using System;
using System.Collections.Generic;

public class Program
{
	// Dynamic Programming, Memoization 기법 적용. 2차원 배열로 구현해도 됨
	// Main 시작과 동시에 미리 값을 전부 계산한 것을 저장하여 
	// 함수에서 값을 불러오는 것은 Tabulation임
	public static Dictionary<(int, int), long> resDict = new Dictionary<(int, int), long>();
	
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		
		for(int i = 0 ; i < count ; i++)
		{
			input = sr.ReadLine();
			int k = int.Parse(input);
			
			input = sr.ReadLine();
			int n = int.Parse(input);
			
			sw.WriteLine(Resident(k, n));
		}
		
		sr.Close();
		sw.Close();
	}
	
	// 재귀 함수로 구현
	public static long Resident(int a, int b)
	{
		// 0층의 b호는 b명의 사람이 거주
		// a층의 1호는 1명 거주
		if(a == 0 || b == 1) return b;
		
		// 딕셔너리에서 저장된 값 탐색
		// 없으면 새로 저장하여 추후 재활용(Memoization)
		if(!resDict.TryGetValue((a, b), out long result))
		{
			result += Resident(a, b - 1) + Resident(a - 1, b);
			
			resDict.Add((a, b), result);
		}
		
		return result;
	}
}