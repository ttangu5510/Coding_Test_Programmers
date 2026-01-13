using System;
using System.Text;

public class Solution {
    public string solution(string[] str_list, string ex) {
        StringBuilder answer = new StringBuilder();
        foreach(var s in str_list)
        {
            if(!s.Contains(ex)) answer.Append(s);
        }
        return answer.ToString();
    }
}