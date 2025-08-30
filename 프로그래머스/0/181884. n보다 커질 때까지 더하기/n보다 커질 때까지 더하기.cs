using System;
using System.Linq;

public class Solution {
    public int solution(int[] numbers, int n) {
        return numbers.Aggregate(0, (sum, x) => sum > n ? sum : sum + x);
    }
}
