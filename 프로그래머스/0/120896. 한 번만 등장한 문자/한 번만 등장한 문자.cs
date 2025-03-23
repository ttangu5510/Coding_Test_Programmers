using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int[] abc = new int[26];
        foreach(char c in s)
        {
            for(int i = 0; i < abc.GetLength(0); i++)
            {
                if (i == c - 97)
                {
                    abc[i]++;
                }
            }
        }
        for(int i = 0; i < abc.Length; i++)
        {
            if (abc[i] == 1)
            {
                answer += (char)(i + 97);
            }
        }
        return answer;
    }
}