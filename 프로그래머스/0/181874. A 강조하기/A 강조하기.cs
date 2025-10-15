using System;

public class Solution {
    public string solution(string myString) {
        char[] answer = myString.ToCharArray();
        for(int i = 0; i < myString.Length; i ++)
        {
            if(answer[i] == 'a')
            {
                answer[i] = 'A';
            }
            else if(answer[i] != 'A' && char.IsUpper(answer[i]))
            {
                answer[i] = char.ToLower(answer[i]);
            }
        }
        return new string(answer);
    }
}