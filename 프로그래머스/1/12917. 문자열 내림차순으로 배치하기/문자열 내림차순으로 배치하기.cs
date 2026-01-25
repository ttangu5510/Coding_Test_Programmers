using System;

public class Solution {
    public string solution(string s) {
        char[] tmp = s.ToCharArray();
        
        for(int i = 0 ; i < tmp.Length; i++)
        {
            int maxIndex = i;
            for(int j = i + 1; j < tmp.Length;j++)
            {
                if(tmp[j] > tmp[maxIndex])
                {
                    maxIndex = j;
                }
            }
            char temp = tmp[maxIndex];
            tmp[maxIndex] = tmp[i];
            tmp[i] = temp;
        }
        
        foreach(char c in tmp)
        {
            Console.Write($"{c} ");
        }
        return new string(tmp);
    }
}