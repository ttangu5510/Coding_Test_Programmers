using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        int count = 0;
        for(int i = 0; i < dic.Length; i++)
        {
            if (dic[i].Length == spell.Length)
            {
                for (int j = 0; j < spell.Length; j++)
                {
                    if (dic[i].Contains(spell[j]))
                    {
                        count++;
                        if (count == dic[i].Length)
                        {
                            answer = 1;
                        }
                    }
                }
                count = 0;
            }                
        }
        return answer;
    }
}