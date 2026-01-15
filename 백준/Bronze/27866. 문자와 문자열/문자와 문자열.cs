using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        var inputIndex = Console.ReadLine();
        if(string.IsNullOrEmpty(inputIndex)) return;
        
        Console.WriteLine(input[int.Parse(inputIndex) - 1]);
    }
}