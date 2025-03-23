using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        string[] engNum = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string temp="";
        while (numbers != "")
        {
            for(int i =0;i<engNum.Length;i++)
            {
                if (numbers.IndexOf(engNum[i]) == 0)
                {
                    numbers = numbers.Substring(numbers.Length - (numbers.Length - engNum[i].Length));
                    temp += i.ToString();
                }
            }
        }
        answer = long.Parse(temp);
        return answer;
    }
}