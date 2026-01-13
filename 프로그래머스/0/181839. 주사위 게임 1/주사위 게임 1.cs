using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        bool isOddA = a % 2 == 1;
        bool isOddB = b % 2 == 1;
        if(isOddA && isOddB)
        {
            answer = (a*a)+(b*b);
        }
        else if(isOddA || isOddB)
        {
            answer = 2 * (a + b);
        }
        else
        {
            answer = Math.Abs(a - b);
        }
        return answer;
    }
}