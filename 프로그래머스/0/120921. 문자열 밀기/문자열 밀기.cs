using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        string[] temp = new string[A.Length];

        for(int i = 0; i < A.Length; i++)
        {
            temp[i] = A.Substring(A.Length - i) + A.Substring(0,A.Length-i);
            if (temp[i]==B)
            {
                return i;
            }
         }            
        return -1;
   
}
}