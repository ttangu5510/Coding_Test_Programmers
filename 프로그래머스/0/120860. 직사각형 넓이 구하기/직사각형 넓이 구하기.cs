using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int[] dotsX = new int[dots.GetLength(0)];
        int[] dotsY = new int[dots.GetLength(0)];
        for(int i = 0; i < dots.GetLength(0); i++)
        {
            dotsX[i] = dots[i, 0];
            dotsY[i] = dots[i, 1];
        }
        Array.Sort(dotsX);
        Array.Sort(dotsY);
        answer = Math.Abs(dotsX[0] - dotsX[2]) * Math.Abs(dotsY[0] - dotsY[2]);
        return answer;
    }
}