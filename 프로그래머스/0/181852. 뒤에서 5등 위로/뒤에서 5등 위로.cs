using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        Array.Sort(num_list);
        int[] answer = new int[num_list.Length - 5];
        for(int i = 5 ; i < num_list.Length ; i++)
        {
            answer[i-5] = num_list[i];
        }
        return answer;
    }
}