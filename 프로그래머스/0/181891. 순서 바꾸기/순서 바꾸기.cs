using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        Array.Copy(num_list, n, answer,0,num_list.Length - n);
        Array.Copy(num_list, 0, answer, num_list.Length - n, n );
        return answer;
    }
}