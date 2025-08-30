using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] names) {
        
        return names.Where((value, index) => index%5==0).ToArray();
    }
}