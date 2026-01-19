using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        answer += n;
        for(int i = 1; i * 2 <= n ; i++)
        {
            if(n % i == 0) answer += i;
        }
        return answer;
    }
}