using System;

public class Solution {
    public int[] solution(int n) {
        int[] answer;
        int[] temp = new int[n+1];
int count = 0;

for(int i = 2; i <= n; i++)
{
    if (n % i == 0)
    {                    
        temp[i] = i;                    
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                count++;
                if (count > 2)
                {
                    temp[i] = 0;                                                                
                }
            }
        }
        count = 0;
    }
}

count = 0;
for(int i = 0;i<temp.Length;i++)
{
    if (temp[i] != 0)
    {
        count++;
    }
}
answer = new int[count];

count = 0;
foreach (int num in temp)
{
    if (num != 0)
    {
        answer[count] = num;
        count++;
    }
}
        return answer;
    }
}