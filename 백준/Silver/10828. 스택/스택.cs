using System;
using System.Text;
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
		
		Stack stack = new Stack();
		
		for(int i = 0; i < count; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			
			switch(inputs[0])
			{
				case "push":
					int num = int.Parse(inputs[1]);
					stack.Push(num);
					break;
				case "pop":
					sw.WriteLine(stack.Pop());
					break;
				case "empty":
					sw.WriteLine(stack.Empty());
					break;
				case "top":
					sw.WriteLine(stack.Peek());
					break;
				case "size":
					sw.WriteLine(stack.size);
					break;
			}
		}
		sr.Close();
		sw.Close();
	}
	
	public class Stack
	{
		private int[] arr;
		private const int createSize = 30;
		private int arrSize = 0;
		public int size { get; private set;} = 0;
		private int topIndex = -1;
		
		public Stack(int size = 0)
		{
			if(size <= 0)
			{
				arr = new int[createSize];
				arrSize = createSize;
			}
			else
			{
				arr = new int[size];
				arrSize = size;
			}
		}
		
		public void Push(int num)
		{
			size++;
			topIndex++;
			
			if(arrSize < size)
			{
				int[] newArr = new int[arrSize * 2];
				Array.Copy(arr, 0, newArr, 0, size - 1);
				arrSize = arrSize * 2;
				arr = newArr;
			}
			
			arr[topIndex] = num;
		}
		
		public int Peek()
		{
			if(size == 0) return -1;
			else return arr[topIndex];
		}
		
		public int Pop()
		{
			int result = -1;
			
			if(size > 0)
			{
				result = arr[topIndex];
				size--;
				topIndex--;
			}
			
			return result;
		}
		
		public int Empty()
		{
			if(size == 0) return 1;
			else return 0;
		}
	}
}