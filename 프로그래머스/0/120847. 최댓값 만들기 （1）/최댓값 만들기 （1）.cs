using System;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers,(num1,num2)=>num2.CompareTo(num1));
        int answer = numbers[0]*numbers[1];
        return answer;
    }
}