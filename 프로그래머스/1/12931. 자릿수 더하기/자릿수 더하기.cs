using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int len = n.ToString().Length;
        for(int i = 0; i < len ; i++)
        {
            answer += n % 10;
            n /= 10;
        }
        return answer;
    }
}