using System;

public class Solution {
    public int solution(int[] num_list, int n) {
        return Array.Exists(num_list, num => num == n) ? 1 : 0;
    }
}