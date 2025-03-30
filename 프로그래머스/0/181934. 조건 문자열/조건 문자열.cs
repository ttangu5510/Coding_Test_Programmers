using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
        if(ineq == ">")
        {
            if (n > m)
            {
                answer = 1;
            }
            else if(eq=="="&& n == m)
            {
                answer = 1;
            }
        }
        else
        {
            if (n < m)
            {
                answer = 1;
            }
            else if (eq == "=" && n == m)
            {
                answer = 1;
            }
        }
        return answer;
    }
}