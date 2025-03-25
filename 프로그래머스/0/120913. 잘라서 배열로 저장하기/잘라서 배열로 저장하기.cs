using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int num = n;
        string[] answer = new string[(my_str.Length-1) / n+1];
        int index = 0;
        for(int i = 0; i < answer.Length; i++)
        {
            if (index+num >= my_str.Length)
            {
                num = my_str.Length - index;
            }             
            answer[i] = my_str.Substring(index, num);
            index += num;
        }
        return answer;
    }
}