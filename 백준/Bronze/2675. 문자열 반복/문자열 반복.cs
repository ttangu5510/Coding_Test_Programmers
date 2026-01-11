using System;

public class Program
{
    public static void Main()
    {
        var inputCases = Console.ReadLine();
        if(string.IsNullOrEmpty(inputCases)) return;
        int caseNum = int.Parse(inputCases);
        string curInput = "";
        string[] curInputs = new string[2];
        for(int i = 0 ; i < caseNum ; i++)
        {
            curInput = Console.ReadLine()??"";
            if(string.IsNullOrEmpty(curInput)) return;
            
            curInputs = curInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int repeat = int.Parse(curInputs[0]);
            
            foreach(char c in curInputs[1])
            {
                for(int j = 0; j < repeat ; j++)
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
        }
    }
}