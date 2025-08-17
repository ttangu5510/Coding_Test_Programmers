using System;

public class Solution {
    public int[] solution(int[] arr, int[] query) {
        int firstIndex = 0;
        int lastIndex = arr.Length - 1;
        for(int i = 0 ; i < query.Length ; i++)
        {
            if(i%2 == 0) // 짝수
            {
                lastIndex = firstIndex + query[i];
            }
            else // 홀수
            {
                firstIndex += query[i];
            }
        }
        if(firstIndex == -1)
        {
            firstIndex = 0;
        }
        int arrayLength = lastIndex - firstIndex + 1;
        int[] answer = new int[arrayLength];
        Array.Copy(arr, firstIndex, answer, 0, arrayLength);
        return answer;
    }
}