using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1) return new int[]{-1};
        
        int minIndex = 0;
        
        for(int i = 1; i < arr.Length; i++)
        {
            if(arr[i] < arr[minIndex]) minIndex = i;
        }
        
        List<int> answer = new List<int>();
        answer.AddRange(arr);
        answer.RemoveAt(minIndex);
        return answer.ToArray();
    }
}