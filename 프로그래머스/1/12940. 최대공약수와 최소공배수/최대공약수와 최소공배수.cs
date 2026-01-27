public class Solution {
    public int[] solution(int n, int m) {
        return new int[] { GCD(n, m), LCM(n, m) };
    }
    public int GCD(int a, int b)
    {
        if(a == 1 || b == 0) return 1;
        int r = a % b;
        if(r == 0) return b;
        else return GCD(b, r);
    }
    public int LCM(int a, int b) => (a * b) / GCD(a, b);
}