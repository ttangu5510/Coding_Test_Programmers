using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        
        for(int i = 0; i< queries.GetLength(0);i++)
        {
            int INF = int.MaxValue;
            for(int j = queries[i,0];j<=queries[i,1];j++)
            {
                if(queries[i,2]<arr[j]&&arr[j]<INF)
                {
                    INF = arr[j];
                    answer[i] = arr[j];
                }
            }
            if(INF == int.MaxValue)
            {
                answer[i] = -1;
            }
        }
        return answer;
    }
}