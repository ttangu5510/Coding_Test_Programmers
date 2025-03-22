using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
                    string[] temp = polynomial.Split(" + ");
            int[] xCount = { 0, 0 };
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Contains('x'))
                {

                    string tempS = temp[i];
                    string[] tempS1 = tempS.Split("x");
                    if (tempS1[0] == "")
                    {
                        xCount[0]++;
                    }
                    else
                    {
                        xCount[0] += int.Parse(tempS1[0]);
                    }

                }
                else
                {
                    xCount[1] += int.Parse(temp[i]);
                }
            }

            string answer1, answer2;
            if (xCount[0] == 0)
            {
                answer1 = "";
            }
            else if (xCount[0] == 1)
            {
                answer1 = "x";
            }
            else
            {
                answer1 = xCount[0].ToString() + "x";
            }

            if (xCount[1] == 0)
            {
                answer2 = "";
            }
            else if (xCount[1] != 0 && xCount[0] == 0)
            {
                answer2 = xCount[1].ToString();
            }
            else
            {
                answer2 = " + " + xCount[1].ToString();
            }

            answer = answer1 + answer2;
        return answer;
    }
}