using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
                char[] temp = my_string.ToCharArray();
        for(int i = 0; i < temp.Length; i++)
        {
            for(int j = i-1; j >= 0; j--)
            {
                if (temp[i] == my_string[j])
                {
                    temp[i] = '0';
                }
            }
        }
        foreach(char c in temp)
        {
            if (c != '0')
            {
                answer += c;
            }
        
        }
        return answer;
    }
}