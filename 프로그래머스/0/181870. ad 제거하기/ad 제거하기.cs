using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[] strArr) {
        string pat = "ad";
        List<string> answer = new List<string>();
        foreach(string s in strArr)
        {
            if(!s.Contains(pat)) answer.Add(s);
        }
        return answer.ToArray();
    }
}