using System;

public class Program{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int num = 0;
        foreach(var c in input)
        {
        	if(c == ' ') continue;
        	
            int n = c - '0';
            num += n * n % 10;
        }
        num %= 10;
        Console.WriteLine(num);
    }
}