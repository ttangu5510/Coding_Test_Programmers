using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        int sum = 0;
        for(int i = 0;i < number.Length;i++)
        {
            sum += int.Parse(number[i].ToString());
        }
        
        answer = sum%9;
        return answer;
    }
}