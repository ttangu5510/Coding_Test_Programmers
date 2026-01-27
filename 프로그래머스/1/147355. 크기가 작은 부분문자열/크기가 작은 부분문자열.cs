using System;
using System.Linq;

public class Solution {
    public int solution(string t, string p) =>
    Enumerable.Range(0, t.Length - p.Length + 1)
              .Count(i => string.Compare(t, i, p, 0, p.Length) <= 0);

}