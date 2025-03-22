using System;

public class Solution {
    public int[] solution(int num, int total) {
                int[] answer = new int[num];

                if (num%2==0){
                    for(int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = i + (total / num) - num/2+1 ;
                    }  
                }
                else{
                    for(int i = 0; i < answer.Length; i++)
                    {
                        answer[i] = i + (total / num) - num/2 ;
                    }
                }
                 
        return answer;
    }
}