using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int dif = 100;
        for(int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i] - n) < dif)
            {
                dif = Math.Abs(array[i] - n);
                answer = array[i];
            }
            else if (Math.Abs(array[i] - n) == dif && array[i] < answer)
            {                    
                answer = array[i];
            }
        }
        return answer;
    }
}