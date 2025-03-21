using System;

public class Solution {
    public int solution(int num, int k) {
        string temp = num.ToString();
for(int i = 0; i < temp.Length; i++)
{
    if ((int)temp[i]-'0' == k)
    {
        return i+1;
    }
}
return -1;
    }
}