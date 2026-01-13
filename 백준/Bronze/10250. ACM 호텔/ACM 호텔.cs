using System;
 
public class Program
{
    public static void Main()
    {
        var inputCount = Console.ReadLine();
        if(string.IsNullOrEmpty(inputCount)) return;
        
        int caseCount = int.Parse(inputCount);
        
        for(int i = 0 ; i < caseCount ; i++)
        {
            var input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) return;
            
            string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int H = int.Parse(inputs[0]);
            int N = int.Parse(inputs[2]);
        	
        	int floor = (N - 1) % H + 1;
            int room = (N - 1) / H + 1 ;
            
            Console.WriteLine(floor * 100 + room);
        }

    }
}