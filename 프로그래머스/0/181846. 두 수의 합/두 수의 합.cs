using System;
using System.Text;

public class Solution {
    public string solution(string a, string b) {
        int aLen = a.Length;
        int bLen = b.Length;
        int cachedAsending = 0;
        
        StringBuilder sb = new StringBuilder();
        
        while(aLen > 0 || bLen > 0)
        {
            aLen--;
            bLen--;
            
            int addVal = cachedAsending;
            cachedAsending = 0;
            
            if(aLen >= 0)
            {
                addVal += a[aLen] - '0';
            }
            
            if(bLen >= 0)
            {
                addVal += b[bLen] - '0';
            }
            if(addVal >= 10)
            {
                cachedAsending = cachedAsending + addVal/10;
                addVal %= 10;
            }
            
            sb.Insert(0,addVal);
        }
        
        if(cachedAsending != 0) sb.Insert(0,cachedAsending);
        
        return sb.ToString();
    }
}