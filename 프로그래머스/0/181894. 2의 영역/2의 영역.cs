using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        
        int startIndex = -1;
        int lastIndex = -1;
        
        for(int i  = 0 ; i < arr.Length ; i++)
        {
            if(arr[i] == 2 && startIndex == -1)
            {
                startIndex = i;
                lastIndex = i;
            }
            else if(arr[i] == 2 && startIndex != -1)
            {
                lastIndex = i;
            }
        }
        if(startIndex == -1)
        {
            return new int[]{-1};
        }
        int[] answer = new int[lastIndex - startIndex + 1];
        for(int i = startIndex ; i <= lastIndex ; i++)
        {
            answer[i-startIndex] = arr[i];
        }
        return answer;
    }
}