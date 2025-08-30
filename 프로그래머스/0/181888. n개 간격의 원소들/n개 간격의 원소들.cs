using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[((num_list.Length - 1) / n) + 1];
        int count = 0;
        for(int i = 0 ; i < num_list.Length ; i++)
        {
            if(i % n  == 0)
            {
                answer[count] = num_list[i];
                count++;
            }
        }
        return answer;
    }
}