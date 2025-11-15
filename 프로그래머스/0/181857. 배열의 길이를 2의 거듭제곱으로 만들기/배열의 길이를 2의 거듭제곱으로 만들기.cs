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
        Array.Resize(ref arr, pw);
        return arr;
    }
}