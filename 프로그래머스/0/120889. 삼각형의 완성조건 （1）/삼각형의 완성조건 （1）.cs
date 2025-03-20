using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides, (num1, num2) => num2.CompareTo(num1));
if (sides[0] < sides[1] + sides[2])
{
    return 1;
}
return 2;
    }
}