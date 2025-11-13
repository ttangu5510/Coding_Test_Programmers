using System;

public class Solution {
    public int solution(string binomial) {
        string[] tmp = binomial.Split(' ');
        int answer = 0;
        int a = int.Parse(tmp[0]);
        int b = int.Parse(tmp[2]);
        switch(tmp[1])
        {
            case "+":
                answer = a + b;
                break;
            case "-":
                answer = a - b;
                break;
            case "*":
                answer = a * b;
                break;
        }
        return answer;
    }
}