using System;

public class Solution {
    public int solution(int[] date1, int[] date2) {
        return int.Parse(string.Concat(date1)) < int.Parse(string.Concat(date2)) ? 1 : 0;
        
    }
}