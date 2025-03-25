using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        Array.Sort(sides,(num1,num2)=>num2.CompareTo(num1));
        for(int i = sides[0]-sides[1]+1; i < sides[0] + sides[1]; i++)
        {
            answer++;
        }
        return answer;
    }
}