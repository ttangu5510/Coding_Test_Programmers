using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int answer = 0;
        for(int i = 0 ; i < numbers.Length ; i++)
        {
            answer += numbers[i];
            if(answer > n) return answer;
        }
        return answer;
    }
}