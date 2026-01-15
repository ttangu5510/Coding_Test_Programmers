using System;

public class Solution {
    public int solution(int[,] board, int k) {
        int answer = 0;
        int rowMax = Math.Min(board.GetLength(0), k + 1);
        int colMax = Math.Min(board.GetLength(1), k + 1);
        for(int i = 0 ; i < rowMax ; i++)
        {
            for(int j = 0 ; j < colMax ; j++)
            {
                if(i + j > k) break;
                answer += board[i,j];
            }
        }
        return answer;
    }
}