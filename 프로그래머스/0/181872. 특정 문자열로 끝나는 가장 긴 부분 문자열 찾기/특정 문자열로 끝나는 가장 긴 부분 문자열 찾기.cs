using System;

public class Solution {
    public string solution(string myString, string pat) {
        int lastIndex = myString.LastIndexOf(pat);
        return myString.Substring(0,lastIndex + pat.Length);
    }
}