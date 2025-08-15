using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string answer = "";
        for(int i = c-1 ; i < my_string.Length ; i+=m)
        {
            answer+=my_string[i];
        }
        return answer;
    }
}