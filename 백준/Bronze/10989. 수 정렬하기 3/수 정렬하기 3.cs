using System;
using System.IO;

public class Program{
    public static void Main()
    {
        StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        
        var input = sr.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        int n = int.Parse(input);
        int[] nums = new int[10001];
        
        for(int i = 0 ; i < n ; i++)
        {
            input = sr.ReadLine();
            nums[int.Parse(input)]++;
        }
        
        for(int i = 0 ; i < 10001 ; i++)
        {
        	if(nums[i] == 0) continue;
        	for(int j = 0; j < nums[i] ; j++)
        	{
        		sw.WriteLine(i);	
        	}
        }
        
        sr.Close();
        sw.Close();
    }
}