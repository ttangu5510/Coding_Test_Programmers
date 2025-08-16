using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int[] indices) {
        char[] tmp = my_string.ToCharArray();
        StringBuilder sb = new StringBuilder();
        for(int i = 0;i<indices.Length;i++)
        {
            tmp[indices[i]] = ' ';
        }
        for(int i = 0;i<tmp.Length;i++)
        {
            if(tmp[i]!=' ') sb.Append(tmp[i]);
        }
        return sb.ToString();
    }
}