public class Solution {
    public string solution(string s)
        => s.Substring((s.Length - 1) / 2, (s.Length - 1) % 2 + 1);
}