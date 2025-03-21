using System;

public class Solution {
    public int solution(int n) {
        int nCounter = 0;
int answer = 0;
for(int i = 4; i <= n;i++)
{
    for(int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            nCounter++;
            if (nCounter >= 3)
            {
                answer++;                            
                break;   
            }                        
        }
    }
    nCounter = 0;
}
        return answer;
    }
}