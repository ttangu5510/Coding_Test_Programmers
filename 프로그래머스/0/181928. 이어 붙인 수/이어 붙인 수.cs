using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int oddNum = 0;
        int evenNum = 0;
        foreach (int num in num_list)
        {
            if (num % 2 == 0)
            {
                evenNum = int.Parse($"{evenNum}{num}");
            }
            else
            {
                oddNum = int.Parse($"{oddNum}{num}");
            }
        }
        answer = evenNum + oddNum;
        return answer;
    }
}