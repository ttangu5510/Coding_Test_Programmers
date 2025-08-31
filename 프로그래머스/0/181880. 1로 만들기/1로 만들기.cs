using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        foreach(var num in num_list)
        {
            answer +=  recursion(num, 0);
        }
        return answer;
    }
    
    private int recursion(int num, int answer)
    {
        if(num == 1) return answer;
        
        if(num % 2 == 0) num /= 2;
        else if(num % 2 == 1) num = (num - 1) / 2;
        
        return recursion(num, answer + 1);
    }
}