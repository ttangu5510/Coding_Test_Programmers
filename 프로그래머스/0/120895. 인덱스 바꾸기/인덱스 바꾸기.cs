using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        char[] temp = my_string.ToCharArray();
        char tempc;
        
        tempc = temp[num1];
        temp[num1] = temp[num2];
        temp[num2] = tempc;
        foreach(char c in temp)
        {
            answer += c;
        }

        return answer;
    }
}