using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        List<string> prefixes = new List<string>();
        for(int i = 0;i<my_string.Length;i++)
        {
            prefixes.Add(my_string.Substring(0,i));
        }
        if(prefixes.Contains(is_prefix)) return 1;
        return 0;
    }
}