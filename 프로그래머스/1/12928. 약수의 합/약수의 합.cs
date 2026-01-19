using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        int answer = n;
        int halfNum = n / 2;
        for(int i = 1; i <= halfNum ; i++)
        {
            if(n % i == 0) answer += i;
        }
        return answer;
    }
}