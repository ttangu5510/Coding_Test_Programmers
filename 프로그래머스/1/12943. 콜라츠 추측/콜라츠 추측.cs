using System;

public class Solution {
    public int solution(int num) {
        long input = num;
        for(int i = 0; i < 500; i++)
        {
            if(input == 1) return i;
            
            if (input % 2 == 0) input /= 2;
            else input = input * 3 + 1;
            
            Console.WriteLine(input);
        }
        return -1;
    }
}