using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int sum = int.Parse($"{a}{b}");
        int triangle = 2*a*b;
        if(sum>=triangle)
        {
            answer = sum;
        }
        else
        {
            answer = triangle;
        }
        return answer;
    }
}