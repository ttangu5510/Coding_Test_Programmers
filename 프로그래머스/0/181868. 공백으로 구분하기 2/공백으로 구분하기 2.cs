using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        string[] tmp = my_string.Split(' ');
        List<string> answer = new List<string>();
        foreach(string s in tmp)
        {
            if(s != "") answer.Add(s);
        }
        return answer.ToArray();
    }
}