using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
                string[] temp = my_string.Split(" ");
        for(int i = 0; i < temp.Length; i++)
        {
            if (temp[i] == "-")
            {
                answer -= int.Parse(temp[i + 1]);
                i++;
            }
            else if (temp[i] == "+")
            {
                continue;
            }
            else
            {
                answer += int.Parse(temp[i]);
            }
        }
                return answer;
    }
}