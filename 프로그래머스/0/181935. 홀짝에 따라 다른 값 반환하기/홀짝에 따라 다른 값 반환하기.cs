using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if(n%2 == 0)
        {
            for(int i = 1; i <= n/2; i++)
            {
                answer += 4 * i * i;
            }
        }
        else
        {
            for(int i =1;i<=(n+1)/2;i++)
            answer += 2*i-1;
        }
        return answer;
    }
}