using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";

        for(int i = 0; i < db.GetLength(0); i++)
        {
            if (db[i, 0] == id_pw[0])
            {
                if (db[i, 1] == id_pw[1])
                {
                    answer = "login";
                }
                else
                {
                    answer = "wrong pw";
                }
            }
        }
        if (answer == "")
        {
            answer = "fail";
        }
        return answer;
    }
}