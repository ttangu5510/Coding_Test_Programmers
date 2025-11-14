using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
        List<int> answer = new List<int>();
        foreach(int n in arr)
        {
            if(!answer.Contains(n))
            {
                answer.Add(n);
                if(answer.Count == k) return answer.ToArray();
            }
        }
        if(answer.Count<k)
        {
            answer.AddRange(Enumerable.Repeat(-1,k - answer.Count));
        }
        return answer.ToArray();
    }
}