public class Solution {
    public bool solution(int x) {
        int sum = 0;
        foreach(var c in x.ToString())
        {
            sum += c - '0';
        }
        if(x % sum == 0) return true;
        return false;
    }
}