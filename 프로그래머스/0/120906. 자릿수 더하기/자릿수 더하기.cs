using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int i = 10;
        while(true){
            if(n%i!=0){
                answer=answer+((n%i)/(i/10));
            }
            if(i>n){
                break;
            }
            i=i*10;
            
        }
        return answer;
    }
}