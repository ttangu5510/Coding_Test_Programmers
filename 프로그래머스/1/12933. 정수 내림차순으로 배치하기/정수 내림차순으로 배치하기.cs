using System;

public class Solution {
    public long solution(long n) {
        char[] nums = n.ToString().ToCharArray();
        Array.Sort(nums, (a,b) => b.CompareTo(a));
        return long.Parse(new string(nums));
    }
}