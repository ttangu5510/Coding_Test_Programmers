using System;
using System.Linq;

public class Solution {
    public int solution(string[] order) {
        return order.Select(x => x.Contains("cafelatte") ? 5000 : 4500).Sum();
    }
}