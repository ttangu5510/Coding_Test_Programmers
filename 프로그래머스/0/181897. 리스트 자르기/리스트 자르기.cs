using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        int a = slicer[0];
        int b = slicer[1];
        int c = slicer[2];
        int[] answer;
        switch(n)
        {
            case 1:
                answer = new int[b+1];
                for(int i = 0; i <= b; i++)
                {
                    answer[i] = num_list[i];
                }
                break;
            case 2:
                answer = new int[num_list.Length-a];
                for(int i = a; i < num_list.Length ; i++)
                {
                    answer[i-a] = num_list[i];
                }
                break;
            case 3:
                answer = new int[b-a+1];
                for(int i = a ; i<=b;i++)
                {
                    answer[i-a] = num_list[i];
                }
                break;
            case 4:
                answer = new int[(b-a)/c+1];
                for(int i = a; i<=b;i+=c)
                {
                    answer[(i-a)/c] = num_list[i];
                }
                break;
            default : 
                answer = null;
                break;
        }
        return answer;
    }
}