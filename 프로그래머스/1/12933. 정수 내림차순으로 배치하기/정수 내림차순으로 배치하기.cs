using System.Linq;

public class Solution {
    public long solution(long n) 
        => long.Parse(n.ToString().OrderByDescending(c => (int)c).ToArray());
}