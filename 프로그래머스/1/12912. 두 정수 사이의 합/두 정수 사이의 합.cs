public class Solution {
    public long solution(int a, int b) {
        if(a == b) return a;

        // 공차수열의 합
        long n = b - a > 0 ? b - a + 1 : a - b + 1;
        return (long) n * (a + b) / 2;
    }
}