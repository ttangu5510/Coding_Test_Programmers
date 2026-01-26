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
		
		Queue<int> q = new Queue<int>();
		StringBuilder sb = new StringBuilder();
		int result = 0;
		
		for(int i = 0; i < count; i++)
		{
			input = sr.ReadLine();
			if(string.IsNullOrEmpty(input)) return;
			
			string[] inputs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			
			switch(inputs[0])
			{
				case "push":
					int num = int.Parse(inputs[1]);
					q.Enqueue(num);
					break;
				case "pop":
					result = q.Dequeue();
					result = result == 0 ? - 1 : result;
					sb.AppendLine(result.ToString());
					break;
				case "empty":
					sb.AppendLine(q.Empty().ToString());
					break;
				case "front":
					result = q.Front();
					result = result == 0 ? - 1 : result;
					sb.AppendLine(result.ToString());
					break;
				case "back":
					result = q.Back();
					result = result == 0 ? - 1 : result;
					sb.AppendLine(result.ToString());
					break;
				case "size":
					sb.AppendLine(q.Size().ToString());
					break;
			}
		}
		sw.Write(sb);
		
		sr.Close();
		sw.Close();
	}
	
	public class Queue<T>
	{
		private T[] arr;
		private const int createSize = 30;
		private int head = 0;
		private int tail = 0;
		
		public Queue(int size = createSize)
		{
			arr = new T[size];
		}
		
		public void Enqueue(T item)
		{
			// 크기 초과 시 배열 2배로 다시 만들기
			if(tail == (head + 1) % arr.Length)
			{
				int curSize = Size();
				T[] newArr = new T[arr.Length * 2];
				for(int i = 0; i < curSize; i++)
				{
					newArr[i] = arr[(tail + i) % arr.Length];
				}
				head = curSize;
				tail = 0;
				arr = newArr;
			}
			
			// 헤드 증가하면서 새로 추가
			arr[head] = item;
			head++;
			if(head == arr.Length) head = 0;
		}
		
		// tail에서 빼야함
		public T Dequeue()
		{
			// 카운트가 0이면 리턴
			if(tail == head) return default!;
			
			T result = arr[tail];
			tail++;
			if(tail == arr.Length ) tail = 0;
			
			return result;
		}
		
		// Dequeue할 때 요소
		public T Front()
		{
			if(head == tail) return default!;
			
			return arr[tail];
		}
		
		// 마지막 Enqueue 요소
		public T Back()
		{
			if(head == tail) return default!;
			
			if(head == 0) return arr[arr.Length - 1];
			else return arr[head - 1];
		}
		
		public int Empty()
		{
			return Size() == 0 ? 1 : 0;
		}
		
		public int Size()
		{
			if(head == tail) return 0;
			
			if(head > tail) return head - tail;
			else return (arr.Length - tail) + head;
		}
	}
}
