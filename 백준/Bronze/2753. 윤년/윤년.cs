using System;
 
public class Program
{
    public static void Main()
    {  
    	var input = Console.ReadLine();
    	if(string.IsNullOrEmpty(input)) return;
    	int value = int.Parse(input);

    	bool isLeap = value % 4 == 0 && value % 100 != 0 || value % 400 == 0;
    	
        Console.WriteLine(isLeap ? 1 : 0);

    }
}