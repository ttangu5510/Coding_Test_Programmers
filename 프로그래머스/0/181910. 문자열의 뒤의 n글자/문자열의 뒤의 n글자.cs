using System;

public class Solution {
    public string solution(string my_string, int n) {
            int m = my_string.Length - n;
            return my_string.Substring(m);
    }
}