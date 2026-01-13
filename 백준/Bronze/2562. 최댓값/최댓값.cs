using System;
 
public class Program
{
    public static void Main()
    {
        int maxVal = 0;
        int index = 0;
        
        for(int i = 1 ; i <= 9 ; i++)
        {
        	var input = Console.ReadLine();
        	if(string.IsNullOrEmpty(input)) return;
        	int value = int.Parse(input);
        	if(value > maxVal) 
        	{
        		maxVal = value;
        		index = i;
        	}
        }
        
        Console.WriteLine($"{maxVal}\n{index}");

    }
}