using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int>answer = new List<int>();
        answer = arr.Where(x => !delete_list.Contains(x)).ToList();
        return answer.ToArray();
    }
}