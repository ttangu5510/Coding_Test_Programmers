using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        List<int> answer = new List<int>();
        int answerInt = 0;
        int ranking = 1;
        
        while(answer.Count<3)
        {
            for(int i = 0 ; i < rank.Length ; i ++)
            {
                if(rank[i] == ranking)
                {
                    if(attendance[i])
                    {
                       answer.Add(i);
                        if(answer.Count ==3) break;
                    }
                    ranking++;
                }
            }
        }
        for(int i = 0 ; i < answer.Count ; i ++)
        {
            if( i == 0 ) answerInt += answer[i] * 10000;
            if( i == 1 ) answerInt += answer[i] * 100;
            if( i == 2 ) answerInt += answer[i];
        }
        return answerInt;
    }
}