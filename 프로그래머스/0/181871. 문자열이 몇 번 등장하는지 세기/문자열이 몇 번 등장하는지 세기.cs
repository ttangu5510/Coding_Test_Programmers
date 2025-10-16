using System;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        for (int i = 0 ; i < myString.Length - pat.Length + 1 ; i++)
        {
            string tmp = myString.Substring(i,pat.Length);
            if( tmp == pat)
            {
                answer++;
            }
        }
        return answer;
    }
}