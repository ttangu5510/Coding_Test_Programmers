using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        
        if((k*2-1)%(numbers.Length)==0)
            return numbers[numbers.Length-1];
        return (k*2-1)%(numbers.Length);
    }
}