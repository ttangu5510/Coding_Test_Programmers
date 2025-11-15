using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        int[] len = new int[31];
        foreach(string s in strArr)
        {
            len[s.Length]++;
        }
        
        return len.Max();
    }
}