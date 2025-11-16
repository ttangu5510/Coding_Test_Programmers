using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        var rankList = new List<(int index, int rank)>();
        for(int i = 0 ; i < rank.Length; i ++)
        {
            if(attendance[i])
            {
                rankList.Add((i,rank[i]));
            }
        }
        var answer = rankList.OrderBy(o=>o.Item2).Take(3).ToArray();
        return answer[0].Item1 * 10000 + answer[1].Item1 * 100 + answer[2].Item1;
    }
}