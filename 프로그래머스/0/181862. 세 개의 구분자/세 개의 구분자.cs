using System;

public class Solution {
    public string[] solution(string myStr) {
        char[] pat = new char[3]{'a','b','c'};
        string[] answer = myStr.Split(pat,StringSplitOptions.RemoveEmptyEntries);
        return answer.Length != 0 ? answer : new string[]{"EMPTY"};
    }
}