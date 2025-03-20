using System;

public class Solution {
    public long solution(int balls, int share) {
        long answer = 1;
        int fac=1;
        int minus = balls-share;
        int minusFac=1;
        if(balls==share){
            return 1;
        }
        else{
            for(int i = 1;i<=share;i++){
                answer = answer*(balls-i+1);
                answer = answer/i;
            }            
        }
        return answer;
    }
}