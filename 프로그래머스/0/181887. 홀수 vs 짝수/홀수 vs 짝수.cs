using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int oddSum = num_list.Where((x, index) => index % 2 != 0).Sum();
        int evenSum = num_list.Where((x, index) => index % 2 == 0).Sum();
        return (int)Math.Max(oddSum,evenSum);
    }
}