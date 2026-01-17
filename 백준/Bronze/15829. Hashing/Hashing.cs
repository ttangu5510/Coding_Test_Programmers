using System;

public class Program
{
	static int mod = 1234567891;
	static int pw = 31;
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int n = int.Parse(input);
		
		input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		long result = 0;
		for(int i = 0; i < input.Length ; i++)
		{
			long val = (input[i] - 'a' + 1) * Pow(pw, i);
			result += val;
		}
		result %= mod;
		Console.WriteLine(result);
	}
	
	public static long Pow(int a, int b)
	{
		// Binary Exponentiation 적용
		// mod 계산 적용
		if(a == 1 || b == 0) return 1;
		
		long result = 1;
		int pow = b;
		int tmp = a;
		
		while(pow > 0)
		{
			if((pow & 1) == 1) result *= tmp % mod;
			pow >>= 1;
			tmp *= tmp;
		}
		return result;
	}
}
