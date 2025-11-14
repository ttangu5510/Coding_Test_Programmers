using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> answer = new List<int>();
        for(int i = 0 ; i < flag.Length ; i++ )
        {
            if(flag[i])
            {
                answer.AddRange(Enumerable.Repeat(arr[i],arr[i]*2));
            }
            else
            {
                int lastIndex = answer.Count - 1;
                for(int j  = 0 ; j < arr[i] ; j++)
                    answer.RemoveAt(lastIndex--);   
            }
            foreach(int n in answer)
                Console.Write(n);
            Console.WriteLine();
        }
        return answer.ToArray();
    }
}