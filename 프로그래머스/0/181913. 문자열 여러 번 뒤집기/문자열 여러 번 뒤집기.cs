using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        char[] arr = my_string.ToCharArray();

        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int s = queries[i, 0];
            int e = queries[i, 1];

            Array.Reverse(arr, s, e - s + 1);
        }

        return new string(arr);
    }
}