using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;        
        string sum1,sum2;
        sum1 = a.ToString() + b.ToString();
        sum2 = b.ToString() + a.ToString();
        if(int.Parse(sum1)>=int.Parse(sum2))
        {
            answer = int.Parse(sum1);
        }
        else
        {
            answer = int.Parse(sum2);            
        }
        return answer;
    }
}