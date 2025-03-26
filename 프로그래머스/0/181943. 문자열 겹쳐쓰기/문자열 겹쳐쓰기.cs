using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        
        string subString1 = my_string.Substring(0, s);
        string subString2 = my_string.Substring(my_string.Length - (my_string.Length-s-overwrite_string.Length));
        string answer = subString1 + overwrite_string + subString2;
        return answer;
    }
}