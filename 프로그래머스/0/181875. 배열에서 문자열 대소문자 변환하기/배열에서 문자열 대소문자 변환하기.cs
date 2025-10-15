using System;

public class Solution {
    public string[] solution(string[] strArr) {
        string[] answer = new string[strArr.Length];
        for(int i = 0 ; i < strArr.Length ; i++)
        {
            if((i+1)%2 == 0)
            {
                answer[i] = strArr[i].ToUpper();
            }
            else{
                answer[i] = strArr[i].ToLower();
            }
        }
        return answer;
    }
}