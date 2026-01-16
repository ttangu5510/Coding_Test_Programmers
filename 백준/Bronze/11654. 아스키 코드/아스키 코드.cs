using System;

public class Program{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        Console.WriteLine((int)input[0]);
    }
}