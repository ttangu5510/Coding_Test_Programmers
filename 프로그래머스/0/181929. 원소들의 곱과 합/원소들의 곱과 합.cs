using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int listCross = 1;
        int listSum = 0;
        foreach (int num in num_list)
        {
            listCross *= num;
            listSum += num;
        }
        if (listCross > listSum * listSum)
        {
            answer = 0;
        }
        else
        {
            answer = 1;
        }
        return answer;
    }
}