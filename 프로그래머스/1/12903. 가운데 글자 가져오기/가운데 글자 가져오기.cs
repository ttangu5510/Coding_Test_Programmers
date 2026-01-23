public class Solution {
    public string solution(string s)
        => s.Substring(s.Length % 2 == 0 ? s.Length / 2 -1 : s.Length / 2, s.Length % 2== 0? 2: 1);
}