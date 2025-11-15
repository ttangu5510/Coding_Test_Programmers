using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        int len = arr.Length;
        int pw = 1;
        for(int i =0 ; i < 11 ; i++)
        {
            if(len < pw<<i)
            {
                pw = pw<<i;
                break;
            }
            else if (len == pw<<i)
            {
                return arr;
            }
        }
        List<int> tmp = new List<int>();
    
        for(int i = 0 ; i < pw ; i++)
        {
            if(i < arr.Length)
                tmp.Add(arr[i]);
            else
                tmp.Add(0);    
        }
        return tmp.ToArray();
    }
}