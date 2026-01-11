using System;

public class Program
{
    public static void Main()
    {
        string inputCases = Console.ReadLine();
        if(string.IsNullOrEmpty(inputCases)) return;
        int caseNum = int.Parse(inputCases);
        
        for(int i = 0 ; i < caseNum ; i++)
        {
            string input = Console.ReadLine();
            int[] num = Array.ConvertAll(input.Split(' ',StringSplitOptions.RemoveEmptyEntries), int.Parse);
            
            Console.WriteLine(num[0]+num[1]);
        }
        
        
    }
}