using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int l, int r) {
        List<int> result = new List<int>(); // 결과들을 저장할 리스트
        Queue<string> q = new Queue<string>(); // BFS 알고리즘을 사용할 거다.

        q.Enqueue("5"); // 첫 숫자로 5를 체크

        while (q.Count > 0)
        {
            string cur = q.Dequeue();
            int num = int.Parse(cur);

            if (num > r) continue; // r 초과하면 확장 안 함
            if (num >= l && num <= r) result.Add(num);

            // 다음에 탐색할 숫자 생성 (0과 5 붙이기)
            // 5로 시작하면, 다음은 50을 탐색 -> 500, 505가 순서대로 Enqueue된다.
            q.Enqueue(cur + "0");
            // 55를 탐색 -> 550, 555 가 순서대로 Enqueue.
            q.Enqueue(cur + "5");
            // 순서대로, 50, 55, 500, 505, 550, 555 를 탐색하게 된다. 정렬이 필요없음.
        }

        if (result.Count == 0) return new int[] { -1 }; // 결과값이 없으면 -1 반환
        return result.ToArray();
    }
}