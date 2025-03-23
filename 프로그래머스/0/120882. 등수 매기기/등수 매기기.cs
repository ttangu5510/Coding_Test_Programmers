using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        int[] tempScore = new int[score.GetLength(0)];
        int rank = 1;
        int studentCount = 0;        
        for (int i = 0; i < tempScore.Length; i++)
        {
            for (int j = 0; j < score.GetLength(1); j++)
            {
                tempScore[i] += score[i, j];
            }
        }
        int[] cloneTemp = (int[])tempScore.Clone();        
        Array.Sort(tempScore, (num1, num2) => num2.CompareTo(num1));
        for (int j = 0; j < tempScore.Length; j++)
        {
            if (j != 0 && tempScore[j] == tempScore[j - 1])
            {
                continue;
            }
            for (int i = 0; i < tempScore.Length; i++)
            {
                if (cloneTemp[i] == tempScore[j])
                {
                    answer[i] = rank;
                    studentCount++;
                }
            }
            rank += studentCount;
            studentCount = 0;
        }
        return answer;
    }
}