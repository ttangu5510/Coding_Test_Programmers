using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        
        if(arr1.Length>arr2.Length) answer = 1;
        else if(arr1.Length<arr2.Length) answer = -1;
        else
        {
            int sumA = arr1.Sum();
            int sumB = arr2.Sum();
            
            if(sumA > sumB) answer = 1;
            else if(sumA < sumB) answer = -1;
        }
        
        return answer;
    }
}