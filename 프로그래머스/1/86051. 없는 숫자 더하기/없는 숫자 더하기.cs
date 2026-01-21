using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int[] sortedNums = new int[10];
        for(int i = 0 ; i < numbers.Length ; i++)
        {
            sortedNums[numbers[i]] = numbers[i];
        }
        for(int i = 0 ; i < sortedNums.Length ; i++)
        {
            if(sortedNums[i] == 0) answer += i;
        }
        return answer;
    }
}