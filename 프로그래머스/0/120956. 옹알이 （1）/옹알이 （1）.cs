using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        int wordsSum = 0;
        string[] words = {"aya", "ye", "woo", "ma"};
        for(int i = 0; i < babbling.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                if (babbling[i].Contains(words[j]))
                {
                    wordsSum += words[j].Length;
                    if (wordsSum == babbling[i].Length)
                    {
                        answer++;
                    }
                }
            
            }
            wordsSum = 0;
        }
                return answer;
            }
        }