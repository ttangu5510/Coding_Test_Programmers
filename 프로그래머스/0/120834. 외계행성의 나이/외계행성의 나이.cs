using System;

public class Solution {
    enum alp { a,b,c,d,e,f,g,h,i,j}
    public string solution(int age) {
        string answer = "";
        string temp = age.ToString();
foreach(char c in temp)
{
    answer += (alp)((int)c-'0');
}
        return answer;
    }
}