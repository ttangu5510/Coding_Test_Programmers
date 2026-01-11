using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        int num = int.Parse(input);
        
        for(int i = 1; i <= 9 ; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}