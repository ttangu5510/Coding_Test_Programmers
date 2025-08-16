using System;

public class Solution {
    public int[] solution(int n, int k) {
        int[] answer = new int[n/k];
        int count = 0;
        for(int i = 1 ; i<=n/k;i++)
        {
            answer[i-1] = i*k;
        }
        return answer;
    }
}