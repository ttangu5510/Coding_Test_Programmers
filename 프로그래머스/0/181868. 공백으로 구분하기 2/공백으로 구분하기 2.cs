using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        return my_string.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    }
}