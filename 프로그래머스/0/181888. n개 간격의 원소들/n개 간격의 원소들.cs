using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        return num_list
            .Where((value,index) => index % n == 0)
            .ToArray();
    }
}