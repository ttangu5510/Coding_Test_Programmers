using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int answer = 0;
        if (a == b&&b == c)
        {
            answer = (3*a*a*a)*(3*a*a)*(3*a);
        }
        else if (a == b&&a!=c)
        {
            answer = (2 * a + c) * (2 * a * a + c * c);
        }
        else if (a == c && a != b)
        {
            answer = (2 * a + b) * (2 * a * a + b * b);
        }
        else if (b == c && b != a)
        {
            answer = (2 * b + a) * (2 * b * b + a * a);
        }
        else
        {
            answer = a + b + c;
        }
        return answer;
    }
}