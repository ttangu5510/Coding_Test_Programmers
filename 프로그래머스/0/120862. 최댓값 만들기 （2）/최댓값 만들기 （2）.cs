using System;

public class Solution {
    public int solution(int[] numbers) {
        
        int numFac = ((numbers.Length-1) * (numbers.Length)) / 2;
        int[] numbers1 = new int[numFac];
        int count = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i+1; j < numbers.Length; j++)
         {
             if (i != j)
             {
            numbers1[count] = numbers[i] * numbers[j];
                count++;
             }
            }
        }
        Array.Sort(numbers1, (num1, num2) => num2.CompareTo(num1));
        int answer = numbers1[0];
        return answer;
    }
}