public class Solution {
    public int[] solution(long n) {
        int len = n.ToString().Length;
        long num = n;
        int[] answer = new int[len];
        
        for(int i = 0 ; i < len ; i++)
        {
            answer[i] = (int)(num % 10);
            num /= 10;
        }
        
        return answer;
    }
}