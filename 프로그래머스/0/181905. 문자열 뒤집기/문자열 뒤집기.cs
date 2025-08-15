using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
        string temp = my_string.Substring(s,e-s+1);
        string reversedTemp = new string(temp.Reverse().ToArray());
        string answer = my_string.Replace(temp,reversedTemp);
        
        
        return answer;
    }
}