using System;
using System.IO;

public class Program
{
    // 47억 미만 수에 대해 결정적인 밑 집합
    private static readonly long[] Bases = { 2, 7, 61 };

    public static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        var input = sr.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int m = int.Parse(parts[0]);
        int n = int.Parse(parts[1]);
        
        for(int i = m; i <= n; i++)
        {
            if(IsPrime(i)) sw.WriteLine(i);
        }
        
        sr.Close();
        sw.Close();
    }

    static long ModPow(long baseVal, long exponent, long mod)
    {
        long result = 1;
        baseVal %= mod;
        
        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
                result = (result * baseVal) % mod;
            
            baseVal = (baseVal * baseVal) % mod;
            exponent >>= 1;
        }
        return result;
    }

    public static bool IsPrime(long n)
    {
        if (n < 2) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0) return false; // 짝수 제외
        
        // n을 2^s+d 형식으로 변경
        long d = n - 1;
        int s = 0;
        
        while ((d & 1) == 0)
        {
            d >>= 1;
            s++;
        }

        foreach (long a in Bases)
        {
            // n보다 크거나 같은 밑은 검사할 필요 없음 (특히 n이 밑 집합에 포함된 소수일 경우)
            if (n <= a) break;

            long x = ModPow(a, d, n);

            if (x == 1 || x == n - 1) continue;

            bool passed = false;
            for (int r = 1; r < s; r++)
            {
                x = (x * x) % n;
                if (x == n - 1)
                {
                    passed = true;
                    break;
                }
            }

            if (!passed) return false;
        }

        return true;
    }
}