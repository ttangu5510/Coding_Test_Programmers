using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        int num = Convert.ToInt32(bin2, 2) + Convert.ToInt32(bin1, 2);
        answer = Convert.ToString(num, 2);
        return answer;
    }
}