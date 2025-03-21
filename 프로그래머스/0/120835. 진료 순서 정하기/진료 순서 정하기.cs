using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        
        // int[] temp = emergency (참조값만 복사됨)

        // 방법 1
        //int[] temp = new int[emergency.Length] ;
        //for (int i = 0; i < emergency.Length; i++){
        //    temp[i] = emergency[i];
        //}

        
        int[] temp = (int [])emergency.Clone();
        Array.Sort(emergency);
        
        for(int i = 0; i < emergency.Length; i++)
        {
            for(int j =0; j< temp.Length; j++)
            {
                if (emergency[i] == temp[j])
                {
                    // i=0 -> 6 // j=3 -> 6
                    answer[i] = emergency.Length-j;
                }
            }
        }
        return answer;
    }
}