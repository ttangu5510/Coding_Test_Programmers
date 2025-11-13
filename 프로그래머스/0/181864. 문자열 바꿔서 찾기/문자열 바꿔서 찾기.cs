using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string myString, string pat) {
        char[] tmp  = new char[pat.Length];
        for(int i = 0 ; i < pat.Length ; i++)
        {
            if(pat[i] == 'A')
            {
                tmp[i] = 'B';
            }
            else
            {
                tmp[i] = 'A';
            }
        }
        string str = new string(tmp);
        Console.Write(str);
        return myString.Contains(str) ? 1 : 0;
    }
}