using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        if(arr1.Length>arr2.Length)
            answer = 1;
        else if(arr1.Length<arr2.Length)
            answer = -1;
        else
        {
            int sumA = 0;
            int sumB = 0;
            foreach(int n in arr1)
            {
                sumA += n;
            }
            foreach(int n in arr2)
            {
                sumB += n;
            }
            if(sumA > sumB)
                answer = 1;
            else if(sumA < sumB)
                answer = -1;
        }
        return answer;
    }
}