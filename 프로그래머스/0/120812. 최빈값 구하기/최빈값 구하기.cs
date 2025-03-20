using System;

public class Solution {
    public int solution(int[] array) {
        int maxValue=0;
        int maxCountValue=0;
        int[] countArray;
        for(int i = 0; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
            }
        }
        countArray = new int[maxValue + 1];

           
        foreach(int num in array)
        {
            countArray[num]++;
        }
        
        for(int i=0;i<countArray.Length;i++){
            if(countArray[i]>maxCountValue){
                maxCountValue = countArray[i];
                maxValue=i;
            }
        }
        int isMax=0;
        foreach(int num in countArray)
        {
            if (num == maxCountValue)
            {
                isMax++;
                if (isMax > 1)
                {
                    return -1;
                }
            }
        }
        int answer=maxValue;
        return answer;
    }
}