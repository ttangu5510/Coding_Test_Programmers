using System;

public class Solution {
    public float solution(int[] numbers) {
        int sum=0;      
        float answer=0;
        
        for(int i = 0;i<numbers.Length;i++){
            sum+=numbers[i];
        }
        answer = (float)sum/numbers.Length;
        return answer;   
    }
}