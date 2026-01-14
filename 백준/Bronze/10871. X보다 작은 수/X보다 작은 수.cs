using System;
using System.Text;

public class Test
{
	public static void Main()
	{
		var inputNX = Console.ReadLine();
		if(string.IsNullOrEmpty(inputNX)) return;
		
		var inputArr = Console.ReadLine();
		if(string.IsNullOrEmpty(inputArr)) return;
		
		int[] numNX = Array.ConvertAll(inputNX.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		int[] numArr = Array.ConvertAll(inputArr.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		StringBuilder sb = new StringBuilder();
		
		foreach(var n in numArr)
		{
			if(n < numNX[1]) sb.Append($"{n} "); 
		}
		
		Console.WriteLine(sb.ToString());
	}
}
