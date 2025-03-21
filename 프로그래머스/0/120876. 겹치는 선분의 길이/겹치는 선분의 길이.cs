using System;
// 문제 쉽게 푸는법 해설:
// 아마 다들 시작을 선분이 해당 좌표를 지나가나를 체크할텐데,
// 예를 들어 예시에서 -1 좌표를 보면 선분 두 개가 체크된다
// 판별식으로는 lines[0,0] <= -1 && -1 <= lines[0,1] 이렇게 된다
// 그래서 해당 선분은 -1 좌표를 지난다고 체크하고 넘어간다
// 그러고 나서 다음 선분을 보니 얘도 -1을 지난다
// 선분 2개가 지나니 당연히 길이 1은 된다고 판단한다
// x좌표 0으로 옮기면 이제 문제가 생긴다 -1부터 0까지 오는 길은
// 지나는 선분이 하나 뿐인데, 앞어 썼던 판별식 방법으로 하면
// 선분이 두개가 지나는 것이 되어 (-1 ~ 0) 구간도 길이 1이 된것처럼 보인다
// 이 부분의 함정때문에 문제가 어려운건데
// 그러지말고 중간을 보자
// (-2 ~ -1) 구간에서 -1.5를 체크하면 선분이 두 개 지난다
// (-1 ~ 0) 구간에서 -0.5를 체크하면 선분 한 개가 지난다
// 이렇게 선분이 두 개 지나는지 한 개 지나는지 판별이 된다

// 1. 모든 좌표 중, 최저 값을 찾는다
// 2. 모든 좌표 중, 최대 값을 찾는다
// 3. 그러고 (최저 좌표 + 0.5) 부터 (최대좌표 -0.5) 까지 위와 같은 판별식을 쓴다
// 선분이 두개 지나면 그것은 길이 1로 판단할 수 있다
public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        int[] minTemp = new int[3];
        int minValue;
        int[] maxTemp = new int[3];
        int maxValue;
        for(int i = 0; i < 3; i++)
        {
            minTemp[i] = lines[i,0];
            
        }
        
        for(int i =0; i< 3; i++)
        {
            maxTemp[i] = lines[i,1];
        }
        // 최저값과 최대값 변수 초기화
        Array.Sort(minTemp);
        Array.Sort(maxTemp,(num1,num2)=>num2.CompareTo(num1));
        minValue = minTemp[0];
        maxValue = maxTemp[0];
        // 특정 좌표에서 선분이 몇개 지나나 체크하기 위한 변수
        int lineCount = 0;
        
        
        for(int i = minValue; i < maxValue; i++)
        {
            // 지금 선분이 좌표에서 지나나 안지나나 체크하기 위한 변수
            float check = (float)(i + 0.5f);
            for (int j = 0; j < 3; j++)
            {                    
                //선분이 좌표 지나는지 판별
                if (check > lines[j,0] && check < lines[j,1])
                {
                    //선분이 지나면 선분 지난다는 카운트
                    lineCount++;
                    if (lineCount == 2)
                    {
                        // 카운트가 2가 되면 길이 +1
                        answer++;
                        break;
                    }
                }
            }
            // 새로운 좌표로 이동하니, 선분 카운트 초기화
            lineCount = 0;
        }
        return answer;
    }
}