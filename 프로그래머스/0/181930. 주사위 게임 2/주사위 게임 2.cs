using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        if (a == b&&b == c)
        {
            answer = (3*a*a*a)*(3*a*a)*(3*a);
        }
        else if (a != b&&b!=c&&a!=c)
        {
            answer = a + b + c;
        }
    
        else
        {
            answer = (a + b + c)*(a*a+b*b+c*c);
        }
        return answer;
    }
}