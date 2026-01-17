public class Solution {
    public double solution(int[] arr) {
        int sum = 0;
        foreach(int a in arr)
        {
            sum += a;
        }
        return (double) sum / arr.Length;
    }
}