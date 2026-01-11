using System;

public class Program{
    public static void Main()
    {
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int row = int.Parse(input);
        for(int i = 0 ; i < row ; i++)
        {
            for(int j = 0 ; j <= i ; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}