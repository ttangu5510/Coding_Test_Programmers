using System;
 
public class Program
{
	public static void Main()
	{
		while(true)
		{
			var input = Console.ReadLine();
			if(string.IsNullOrEmpty(input) || input == "0") return;
 
			char[] tmp = new char[input.Length];
			for(int i = 0 ; i < tmp.Length; i++)
			{
				tmp[i] = input[input.Length - i - 1];
			}
			Console.WriteLine(new string(tmp) == input ? "yes" : "no");
		}
	}
}