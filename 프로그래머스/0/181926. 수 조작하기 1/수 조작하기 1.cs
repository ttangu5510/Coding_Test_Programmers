using System;

public class Solution {
    public int solution(int n, string control) {
        int answer = n;
        foreach(char c in control)
        {
            switch(c)
            {
                case 'w':
                    answer++;
                    break;
                case 's':
                    answer--;
                    break;
                case 'd':
                    answer+=10;
                    break;
                case 'a':
                    answer-=10;
                    break;                    
            }            
        }        
        return answer;
    }
}