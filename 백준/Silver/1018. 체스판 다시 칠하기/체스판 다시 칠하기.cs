using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		char[][] board = new char[nums[0]][];
		
		for(int i = 0; i< nums[0]; i++)
		{
			input = sr.ReadLine();
			board[i] = input!.ToCharArray();
		}
		int min = int.MaxValue;
		
		for(int i = 0; i < nums[0] - 7; i++)
		{
			for(int j = 0; j < nums[1] - 7; j++)
			{
				int result = CheckBoard(board, i, j);
				if(result < min) min = result;
			}
		}
		
		Console.Write(min);
	}
	
	public static int CheckBoard(char[][] board, int row, int column)
	{
		int result = 0;
		int resultFlip = 0; // 시작 칸을 칠하는 경우
		
		for(int i = row; i < row + 8; i++)
		{
			for(int j = column; j < column + 8; j++)
			{
				int sumIndex = i + j - row - column;
				bool isSame = board[i][j] == board[row][column];
				
				if(sumIndex % 2 == 0) // 같은 색이어야 하는 경우
				{
					if(!isSame)
					{
						result++; // 해당 칸을 칠함
					}
					else 
					{
						resultFlip++; // 
					}
				}
				else // 다른 색이어야 하는 경우
				{
					if(!isSame) resultFlip++;
					else result++;
				}
			}
		}
		return Math.Min(result, resultFlip);
	}
}