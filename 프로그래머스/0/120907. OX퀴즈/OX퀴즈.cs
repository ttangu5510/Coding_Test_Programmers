using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[,] arrayQuiz = new string[quiz.Length, 5];
string[] tempQuiz = new string[5];
string[] answer = new string[quiz.Length];

for (int i = 0; i < quiz.Length; i++)
{
    tempQuiz = quiz[i].Split(" ");
    for (int j = 0; j < tempQuiz.Length; j++)
    {
        arrayQuiz[i, j] = tempQuiz[j];
    }
}

for (int i = 0; i < arrayQuiz.GetLength(0); i++)
{
    if (arrayQuiz[i, 1] == "+")
    {
        if (int.Parse(arrayQuiz[i, 0]) + int.Parse(arrayQuiz[i, 2]) == int.Parse(arrayQuiz[i, 4]))
        {
            answer[i] = "O";
        }
        else
        {
            answer[i] = "X";
        }
    }
    else if (arrayQuiz[i,1] == "-")
    {
        if (int.Parse(arrayQuiz[i, 0]) - int.Parse(arrayQuiz[i, 2]) == int.Parse(arrayQuiz[i, 4]))
        {
            answer[i] = "O";
        }
        else
        {
            answer[i] = "X";
        }
    }
}
        
        return answer;
    }
}