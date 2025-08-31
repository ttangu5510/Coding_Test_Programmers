using System;

public class Solution {
    public int solution(int[] arr) {
        int count = recursion(arr, 0);
        return count;
    }
    private int recursion(int[] arr, int count)
    {
        int[] next = (int[])arr.Clone();
        
        for(int i =  0; i < arr.Length; i++)
        {
            if(next[i] >= 50 && next[i] % 2 == 0 ) next[i] /= 2;
            else if(next[i] < 50 && next[i] % 2 == 1) next[i] = next[i] * 2 + 1;
        }
        
        if(next.AsSpan().SequenceEqual(arr)) return count;
        
        return recursion(next, count + 1);
    }
    
}