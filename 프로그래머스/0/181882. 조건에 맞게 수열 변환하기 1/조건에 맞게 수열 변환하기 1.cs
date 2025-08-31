using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        return arr.Select(num =>
            (num >= 50 && num%2 == 0) ? num /= 2 :
            (num < 50 && num % 2 == 1) ? num *= 2 : num
        ).ToArray();
    }
}