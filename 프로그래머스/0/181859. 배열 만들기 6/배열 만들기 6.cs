using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        Stack<int> answer = new Stack<int>();
        for(int i =  0 ; i < arr.Length ; i++)
        {
            if(answer.Count == 0)
                answer.Push(arr[i]);
            else
            {
                if(answer.Peek() == arr[i])
                {
                    answer.Pop();
                }
                else
                {
                    answer.Push(arr[i]);
                }
            }
        }
        return answer.Count == 0 ? new int[1]{-1}: answer.Reverse().ToArray();
    }
}