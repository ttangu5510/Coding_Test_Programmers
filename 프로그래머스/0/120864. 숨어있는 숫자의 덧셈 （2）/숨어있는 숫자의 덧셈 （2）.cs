using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] temp = new string[my_string.Length];
        int count = 0;
        foreach(char c in my_string)
        {
            if (char.IsDigit(c))
            {
                temp[count] += c.ToString();
                
            }
            else if (!char.IsDigit(c) && temp[count]!=null)
            {
                count++;
            }
        }
        foreach(string num in temp)
        {
            if (num != null)
            {
               answer += int.Parse(num);
            }
           
        }
        
        return answer;
    }
}