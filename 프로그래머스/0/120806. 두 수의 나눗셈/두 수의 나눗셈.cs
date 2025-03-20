using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;
        float temp;
        temp = (float)num1/num2*1000;
        answer = (int)temp/1;
        return answer;
    }
}