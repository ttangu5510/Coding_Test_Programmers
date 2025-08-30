using System;

public class Solution {
    public string[] solution(string[] names) {
        string[] answer = new string[((names.Length - 1) / 5) + 1];
        for(int i = 0; i < answer.Length ; i++)
        {
            answer[i] = names[i*5];
        }
        return answer;
    }
}