using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
        
        for(int i = 0 ; i < my_strings.Length ; i++)
        {
            int startIndex = parts[i, 0];
            int endIndex = parts[i, 1];
            int length = endIndex - startIndex+1;
            answer += my_strings[i].Substring(startIndex,length);
        }
        return answer;
    }
}