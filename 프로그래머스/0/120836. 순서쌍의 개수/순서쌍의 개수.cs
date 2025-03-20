using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i =1;i<=n;i++){
            for(int j = 1;i*j<=n;j++){
                if(i*j==n){
                    answer++;
                }
            }
        }
        return answer;
    }
}