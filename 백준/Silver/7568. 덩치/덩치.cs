using System;

public class Test
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		int[,] arr = new int[count, 2];
		
		for(int i = 0 ; i < count ; i++)
		{
			input = Console.ReadLine();
			string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			arr[i, 0] = int.Parse(inputs[0]);
			arr[i, 1] = int.Parse(inputs[1]);
		}
		
		for(int i = 0 ; i < count ; i++)
		{
			int n = 0;
			
			for(int j = 0; j < count ; j++)
			{
				if(arr[i , 0] < arr[j , 0] && arr[i, 1] < arr[j, 1]) n++;
			}
			Console.Write($"{n + 1} ");
		}
	}
}