using System.Linq;

public class Solution {
    public bool solution(int x)
        => x % x.ToString().Select(c => (int)c - '0').Sum() == 0;
}