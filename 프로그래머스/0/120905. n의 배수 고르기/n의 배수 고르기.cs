using System;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        int count=0;
        int[] answer;
foreach(int a in numlist)
{
    if (a % n == 0)
    {
        count++;
    }
}
answer = new int[count];
count = 0;
for(int i = 0; i < numlist.Length; i++)
{
    if (numlist[i] % n == 0)
    {
        answer[count] = numlist[i];
        count++;
    }
}

        return answer;
    }
}