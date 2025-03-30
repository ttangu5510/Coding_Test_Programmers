using System;

public class Solution {
    public string solution(string code) {
        int mode = 0;
        string ret = "";
        for (int idx = 0; idx < code.Length; idx++)
        {
            if (mode == 0)
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 0)
                    {
                        ret = $"{ret}{code[idx]}";
                    }
                }
                else
                {
                    mode = 1;
                }
            }
            else
            {
                if (code[idx] != '1')
                {
                    if (idx % 2 == 1)
                    {
                        ret = $"{ret}{code[idx]}";
                    }
                }
                else
                {
                    mode = 0;
                }
            }        
        }
        if(ret=="")
        {
            ret = "EMPTY";            
        }
        return ret;
    }
}