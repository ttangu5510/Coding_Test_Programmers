using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        List<string> result = new List<string>();
        StringBuilder sb = new StringBuilder();
        foreach(var s in picture)
        {
            sb.Clear();
            foreach(var c in s)
            {
                for(int i = 0; i < k ; i++)
                {
                    sb.Append(c);
                }
            }
            for(int i = 0 ; i < k ; i++)
            {
                result.Add(sb.ToString());
            }
        }
        return result.ToArray();
    }
}