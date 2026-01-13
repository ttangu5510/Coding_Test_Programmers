using System;
 
public class Program
{
    public static void Main()
    {
        var inputTime = Console.ReadLine();
        if(string.IsNullOrEmpty(inputTime)) return;
 
        string[] times = inputTime.Split(' ',StringSplitOptions.RemoveEmptyEntries);
 
        int hour = int.Parse(times[0]);
        int minute = int.Parse(times[1]);
 
        if(minute - 45 < 0)
        {
        	minute += 15;
        	if(hour - 1 < 0) hour = 23;
        	else hour -= 1;
        }
        else
        {
        	minute -= 45;
        }
        Console.WriteLine($"{hour} {minute}");
 
    }
}