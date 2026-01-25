using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long need = (count * (price + (long)price * count)) / 2;
        return need - money > 0 ? need - money : 0;
    }
}