using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n, n];
        
        bool[,] visited = new bool[n, n];
        
        int x = 0;
        int moveX = 1; // 초기 방향 Right
        int y = 0;
        int moveY = 0;
        int curVal = 1;
        
        while(true)
        {
            // 현재 좌표에 값 입력 및 visited 값 업데이트
            answer[y, x] = curVal;
            curVal++;
            visited[y, x] = true;
            
            // 다음이 움직일 수 있는 곳인지 체크
            // 1. 다음좌표가 인덱스 내부인가?
            // 2. 다음좌표를 방문했는가?
            bool canMoveNext = x + moveX < n 
                && x + moveX >= 0 
                && y + moveY < n 
                && y + moveY >= 0 
                && !visited[y + moveY, x + moveX];
            
            // false: 진행방향 변경
            if(!canMoveNext)
            {
                if(moveX != 0) // Right 였을 경우, Down으로 변경
                               // Left 였을 경우, Up으로 변경
                {
                    moveY = moveX;
                    moveX = 0;
                }
                else if(moveY != 0) // Up 이였을 경우, Right로 변경
                                    // Down 이였을 경우, Left로 변경
                {
                    moveX = -moveY;
                    moveY = 0;
                }
            }
            
            // 진행 방향 바꿨는데도 이동이 불가능한 경우 끝난거임
            canMoveNext = x + moveX < n 
                && x + moveX >= 0 
                && y + moveY < n 
                && y + moveY >= 0 
                && !visited[y + moveY, x + moveX];
            
            if(!canMoveNext) break;
            
            // 이동이 가능하면 이동
            x += moveX;
            y += moveY;
        }
        return answer;
    }
}