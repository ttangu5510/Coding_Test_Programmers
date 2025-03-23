using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = { 0, 0 };
        foreach(string s in keyinput)
        {
            switch (s)
            {
                case "up":
                    if (answer[1] + 1 <= board[1]/2)
                    {
                        answer[1] += 1;
                    }
                    break;
                case "down":
                    if (answer[1] - 1 >= -board[1] / 2)
                    {
                        answer[1] -= 1;
                    }
                    break;
                case "left":
                    if (answer[0] - 1 >= -board[0] / 2)
                    {
                        answer[0] -= 1;
                    }
                    break;
                case "right":
                    if (answer[0] + 1 <= board[0] / 2)
                    {
                        answer[0] += 1;
                    }
                    break;
            }
        }
        return answer;
    }
}