using System;
using System.IO;
using System.Text;

public class Program
{
    public static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        var input = sr.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int m = int.Parse(tokens[0]);
        int n = int.Parse(tokens[1]);

        // 에라토스테네스의 체
        bool[] isPrime = new bool[n + 1];
        
        // 초기화: 일단 모두 소수(true)라고 가정
        // 0과 1은 소수가 아님
        Array.Fill(isPrime, true);
        if(n >= 0) isPrime[0] = false;
        if(n >= 1) isPrime[1] = false;

        for (int i = 2; i * i <= n; i++)
        {
            if (isPrime[i])
            {
                // i의 배수들을 모두 지움 (i*i부터 시작해도 됨)
                for (int j = i * i; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // 출력
        for (int i = m; i <= n; i++)
        {
            if (isPrime[i])
            {
                sw.WriteLine(i);
            }
        }

        sr.Close();
        sw.Close();
    }
}