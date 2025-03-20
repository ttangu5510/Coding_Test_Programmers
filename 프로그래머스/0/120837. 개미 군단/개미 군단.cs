using System;

public class Solution {
    public int solution(int hp) {
        int answer = 0;
        int 장군개미 = hp/5;
        hp -= 장군개미*5;
        int 병정개미 = hp/3;
        hp -= 병정개미*3;
        int 일개미 = hp;
        answer = 장군개미 + 병정개미 + 일개미;
        return answer;
    }
}