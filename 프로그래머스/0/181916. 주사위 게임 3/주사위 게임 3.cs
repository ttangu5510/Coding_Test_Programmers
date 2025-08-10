using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 6;
        int[] board = new int[7];
        board[a]++;
        board[b]++;
        board[c]++;
        board[d]++;
        for(int i =0;i<board.Length ; i++)
        {
            if(board[i] == 4)
            {
                return i*1111;
            }
            if(board[i] == 3)
            {
                for(int j = 0;j<board.Length;j++)
                {
                    if(board[j] == 1)
                    {
                        return (int)Math.Pow((10*i+j),2);
                    }
                }
            }
            if(board[i] == 2)
            {
                for(int j = 0;j<board.Length;j++)
                {
                    if(board[j]==2 && j!=i)
                    {
                        return (i+j)*(int)Math.Abs(i-j);
                    }
                    if(board[j]==1)
                    {
                        for(int k = 0;k<board.Length;k++)
                        {
                            if(board[k] == 1 && j != k)
                            {
                                return j*k;
                            }
                        }
                    }
                }
            }
            if(board[i] == 1 && i < answer)
            {
                answer = i;
            }
        }
        return answer;
    }
}