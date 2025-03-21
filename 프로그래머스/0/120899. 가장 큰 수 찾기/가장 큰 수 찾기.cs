using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] maxValue= new int[2];
        maxValue[0] = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if (maxValue[0] < array[i])
            {
                maxValue[0] = array[i];
                maxValue[1] = i;
            }
        }
        int[] answer = maxValue;

        return answer;
    }
}