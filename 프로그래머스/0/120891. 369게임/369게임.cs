using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
         string temp = order.ToString();
 foreach(char c in temp)
 {
     if (c % 3 == 0&&c!='0')
     {
         answer++;
     }
 }

        return answer;
    }
}