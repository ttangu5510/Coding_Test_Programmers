using System;

public class Program{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int[] nums = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        int primes = 0;
        foreach(int n in nums)
        {
            if(IsPrime(n)) primes++;
        }
        Console.WriteLine(primes);
    }
    
    public static bool IsPrime(long n)
    {
        if(n <= 1) return false;
        if(n == 2 || n == 3) return true;
        
        for(int i = 2; i * i<= n ; i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }
}