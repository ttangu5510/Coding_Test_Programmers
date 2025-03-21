using System;

public class Solution {
    public int[] solution(int n) {
        string temp = "";
        for(int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                temp += i.ToString()+" ";     
            }
        }
        string[] temps = temp.Split(" ");
        int[] answer = new int[temps.Length-1];
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = int.Parse(temps[i]);
        }

        return answer;
    }
}