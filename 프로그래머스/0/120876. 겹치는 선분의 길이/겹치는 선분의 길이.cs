using System;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        int[] minTemp = new int[3];
        int minValue;
        int[] maxTemp = new int[3];
        int maxValue;
        for(int i = 0; i < 3; i++)
        {
            minTemp[i] = lines[i,0];
            
        }
        
        for(int i =0; i< 3; i++)
        {
            maxTemp[i] = lines[i,1];
        }
        
        Array.Sort(minTemp);
        Array.Sort(maxTemp,(num1,num2)=>num2.CompareTo(num1));
        minValue = minTemp[0];
        maxValue = maxTemp[0];
        int lineCount = 0;
        
        
        for(int i = minValue; i < maxValue; i++)
        {
            float check = (float)(i + 0.5f);
            for (int j = 0; j < 3; j++)
            {                    
                if (check > lines[j,0] && check < lines[j,1])
                {
                    lineCount++;
                    if (lineCount == 2)
                    {
                        answer++;
                        break;
                    }
                }
            }
            lineCount = 0;
        }
        return answer;
    }
}