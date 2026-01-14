using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        return arr.Select(x => k % 2 == 0 ? x + k : x * k).ToArray();
    }
}