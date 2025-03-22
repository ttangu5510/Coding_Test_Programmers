using System;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        int[] answer = new int[numlist.Length];
        int count = 0;
        for(int k =0;k<numlist.Length;k++)
        {
            if(numlist[k]==n)
            {
                answer[0]=n;
                count++;
            }
        }
        for (int i = 1; i < 10000; i++)
        {
            
            for (int j = 0; j < numlist.Length; j++)
            {
                if (numlist[j] == n + i && n + i <= 10000)
                {
                    answer[count] = numlist[j];
                    count++;
                }
        
            }
            for (int j = 0; j < numlist.Length; j++)
            {
                if (numlist[j] == n - i && n - i >= 1)
                {
                    answer[count] = numlist[j];
                    count++;
                }
            }
        }
        return answer;
    }
}