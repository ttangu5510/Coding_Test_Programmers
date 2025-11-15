using System;

public class Solution {
    public int[] solution(int[] arr, int n) {
        int num = -1;
        
        if(arr.Length % 2 == 0) num = 1;
        else num = 0;
        
        for(int i = num ; i < arr.Length ; i += 2)
        {
            arr[i] += n;
        }
        return arr;
    }
}