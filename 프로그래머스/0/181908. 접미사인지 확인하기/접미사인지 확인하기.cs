using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        List<string> strs = new List<string>();
        for(int i = 0; i<my_string.Length ; i++)
        {
            strs.Add(my_string.Substring(i));
            Console.WriteLine($"{my_string.Substring(i)}");
        }
                return strs.Contains(is_suffix)?1:0;
    }
}