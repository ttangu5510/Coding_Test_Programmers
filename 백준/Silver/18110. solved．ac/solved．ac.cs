using System;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		
		if(count == 0)
		{
			Console.WriteLine(0);
			return;
		}
		
		int[] arr = new int[count];
		for(int i = 0 ; i < count; i++)
		{
			input = sr.ReadLine();
			arr[i] = int.Parse(input!);
		}
		
		Array.Sort(arr);
		int cut = (int)Math.Round(arr.Length * 0.15, MidpointRounding.AwayFromZero);
		int answer = 0;
		
		for(int i = cut; i < arr.Length - cut; i++)
		{
			answer += arr[i];
		}
		Console.WriteLine(Math.Round((float) answer / (arr.Length - 2 * cut), MidpointRounding.AwayFromZero));
		sr.Close();
	}
}