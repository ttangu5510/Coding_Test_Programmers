using System;

public class Program{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int n = int.Parse(input);
        
        input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int[] size = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        
        input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int[] bundle = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        
        int shirtSet = 0;
        foreach(int s in size)
        {
            if(s == 0) continue;
            shirtSet += (s - 1) / bundle[0] + 1;
        }
        Console.WriteLine($"{shirtSet}\n{n / bundle[1]} {n % bundle[1]}");
        
    }
}