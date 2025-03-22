using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        if(board.GetLength(0)==1)
        {
            if(board[0,0]==1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                int mineCount = 0;
                int minINum = i - 1;
                int maxINum = i + 1;
                int minJNum = j - 1;
                int maxJNum = j + 1;
                
                //윗줄에 있을 경우                        
                if (i == 0)
                {
                    minINum = 0;
                }
                //아랫줄일 경우
                else if (i == board.GetLength(0) - 1)
                {
                    maxINum = board.GetLength(0) - 1;
                }
                //왼쪽
                if (j == 0)
                {
                    minJNum = 0;
                }
                //오른쪽
                else if (j == board.GetLength(1) - 1)
                {
                    maxJNum = board.GetLength(1) - 1;
                }
                
                //범위 내 지뢰 체크
                for(int y = minINum; y <= maxINum; y++)
                {
                    for(int x = minJNum; x <= maxJNum; x++)
                    {
                        if (board[y, x] == 1)
                        {
                            mineCount++;
                        }
                    }
                }
        
                // 지뢰 없으면 안전 칸
                if (mineCount == 0)
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}