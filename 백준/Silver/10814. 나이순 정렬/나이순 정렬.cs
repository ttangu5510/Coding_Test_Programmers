using System;
using System.Linq;
using System.IO;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		List<(int, int, string)> person = new List<(int, int, string)>();
		
		for(int i = 0 ; i < count ; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			person.Add((int.Parse(inputs[0]), i, inputs[1]));
		}
		person.Sort((x,y) => {
			int result = x.Item1.CompareTo(y.Item1);
			if(result == 0) return x.Item2.CompareTo(y.Item2);
			return result;
		});
		
		foreach(var p in person)
		{
			sw.WriteLine($"{p.Item1} {p.Item3}");
		}
		
		sr.Close();
		sw.Close();
	}
}