using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 1;
        char[] beforeSort = before.ToCharArray();
        char[] afterSort = after.ToCharArray();
        Array.Sort(beforeSort);
        Array.Sort(afterSort);
        for(int i = 0; i < beforeSort.Length; i++)
        {
            if (beforeSort[i] != afterSort[i])
            {
                answer = 0;
            }
        }
        return answer;
    }
}