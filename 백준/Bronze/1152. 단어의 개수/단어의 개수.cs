using System;
 
public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(inputs.Length);
    }
}