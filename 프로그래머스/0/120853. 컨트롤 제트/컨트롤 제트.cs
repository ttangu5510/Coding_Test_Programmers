using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        string[] temp = s.Split(" ");
for(int i = 0;i<temp.Length;i++)
{
    if (temp[i] != "Z")
    {
        answer += int.Parse(temp[i]);
    }
    else
    {
        answer -= int.Parse(temp[i - 1]);
    }
}
        return answer;
    }
}