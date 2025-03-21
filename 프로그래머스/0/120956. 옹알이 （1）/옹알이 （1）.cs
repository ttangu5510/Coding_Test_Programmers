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
/// <뻘짓>
//int[] indexNum = new int[3];
//Console.WriteLine(babbling[0].IndexOf(words[0]) + " " + words[0].Length);
//int indexNum = babbling[0].IndexOf(words[0]);
//int lengthOfWords = words[0].Length;
//answer[1] = babbling[0].Substring(indexNum, lengthOfWords);
//answer[2] = babbling[0].Substring(0, 3);
//answer[0] = babbling[0].Substring(babbling[0].IndexOf(words[0]), words[0].Length);
//Console.Write(answer[0]+" " + answer[1]+" " + answer[2]+" " + babbling[0]);
//// Substring 은 "추출" 이다. 제거가 아니다...

// <정답>
// 바블링에서 워즈 인덱스넘, 인덱스길이 찾음 = 모든단어
// -> 얘들 길이 합했는데, 바블링이 더 길면 X 같으면 answer ++
// 단어 하나하나 indexNum,words길이 저장 필요 ->  babbling 마다 하나의 sum으로 모음
// 단어 길이의 합 = 옹알이 길이 -> 무조건 정답
