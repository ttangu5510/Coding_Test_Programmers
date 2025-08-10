using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = false;
        // 집합 관계로 표현 가능함
        //if((!x1 && !x2) || (!x3 && !x4)) answer = false;
        
        // 드모르간 법칙을 적용하면 아래와 같음
        //if(!(x1 || x2) || !(x3 || x4)) answer = false;
        
        // 한 번 더 적용하면 아래와 같음
        //if(!((x1 || x2) && (x3 || x4))) answer = false;
        
        // 카르노 맵으로 작성하면 아래와 같음. answer = false로 설정해놔야 한다. 벨로그 참고
        if((x1||x2)&&(x3||x4)) answer = true;
        return answer;
    }
}