using System;
using System.Text;

public class Solution {
    public string solution(string n_str) {
        char[] tmp = n_str.ToCharArray();
        StringBuilder sb = new StringBuilder();
        int index = 0;
        for(int i = 0 ; i < tmp.Length;i++)
        {
            if(tmp[i] == '0') continue;
            else
            {
                index = i;
                break;
            }
            
        }
        for(int i = index ; i < tmp.Length ; i++)
        {
            sb.Append(tmp[i]);
        }
        return sb.ToString();
    }
}