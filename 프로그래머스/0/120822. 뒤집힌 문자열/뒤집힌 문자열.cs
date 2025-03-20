using System;

public class Solution {
    public string solution(string my_string) {
        char[] tempArray = my_string.ToCharArray();
        Array.Reverse(tempArray);
        string answer = new string(tempArray);
        return answer;
    }
}