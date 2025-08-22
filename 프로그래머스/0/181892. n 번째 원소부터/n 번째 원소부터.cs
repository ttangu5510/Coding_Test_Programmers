using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length - n + 1];
        Array.Copy(num_list, n - 1, answer, 0, num_list.Length - n + 1);
        return answer;
    }
}