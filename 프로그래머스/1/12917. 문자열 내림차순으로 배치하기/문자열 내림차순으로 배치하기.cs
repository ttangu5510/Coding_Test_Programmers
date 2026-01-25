using System;

public class Solution {
    public string solution(string s) {
        char[] chArr = s.ToCharArray();
        Array.Sort(chArr, (x,y) => y.CompareTo(x));
        return new string(chArr);
    }
}
        