public class Solution {
    public int[] solution(long n) {
        string str = n.ToString();
        int[] answer = new int[str.Length];
        
        for(int i = str.Length - 1 ; i >= 0 ; i--)
        {
            answer[str.Length - i - 1] = str[i] - '0';
        }
        
        return answer;
    }
}