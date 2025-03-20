using System;

public class Solution {
    public int solution(int n) {
        int answer=0;
        int 최소공배수;
        for(int i = 1;i<=n;i++){
            최소공배수 = 6*i;
            if(최소공배수%n==0){
                answer = 최소공배수/6;
                break;
            }
            
        }
        return answer;
    }
}