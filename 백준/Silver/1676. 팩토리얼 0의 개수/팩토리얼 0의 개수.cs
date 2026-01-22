using System;

public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int num = int.Parse(input);
		int count = 0;
		
		while(num >= 5)
        {
            count += num / 5;
            num /= 5;
        }
		Console.WriteLine(count);
	}
}