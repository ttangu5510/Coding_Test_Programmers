using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        foreach(char a in my_string){
            for(int i=n;i>0;i--){
                answer=answer+a;
            }
        }
        return answer;
    }
}