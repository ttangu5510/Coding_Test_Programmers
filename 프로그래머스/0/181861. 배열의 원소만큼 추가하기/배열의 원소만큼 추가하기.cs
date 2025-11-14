using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        foreach(int n in arr)
        {
            for(int i = 0 ; i < n ; i ++)
            {
                answer.Add(n);
            }
        }
        return answer.ToArray();
    }
}