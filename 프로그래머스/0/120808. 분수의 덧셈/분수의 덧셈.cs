using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int numerator = (numer1 * denom2 + numer2 * denom1);
        int denominator = denom1 * denom2;
        for(int i = 2; i < denominator; i++)
        {
            while (denominator % i == 0&&numerator%i==0)
            {
                denominator /= i;
                numerator /= i;
            }
        }
        int[] answer = {numerator,denominator};
        return answer;
    }
}