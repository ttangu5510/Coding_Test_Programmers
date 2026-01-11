using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        int[] num = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
        
        Console.WriteLine(num[0]+num[1]);
        Console.WriteLine(num[0]-num[1]);
        Console.WriteLine(num[0]*num[1]);
        Console.WriteLine(num[0]/num[1]);
        Console.WriteLine(num[0]%num[1]);
    }
}