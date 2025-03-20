using System;

public class Solution {
    public int solution(int n) {
        int factorial = 1;
        int answer = 0;
        for(int i = 1;i <= 11;i++){
            factorial *= i;
            if(factorial > n){
                answer = i - 1;
                break;
            }
        }
        return answer;
    }
}