using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    static readonly long[] pow26 = new long[12];     // 26^k
    static readonly long[] prefix = new long[12];    // Σ(26^1..26^k)

    public Solution()
    {
        // 미리 계산
        pow26[0] = 1;
        for (int i = 1; i <= 11; i++)
            pow26[i] = pow26[i - 1] * 26;

        prefix[0] = 0;
        for (int i = 1; i <= 11; i++)
            prefix[i] = prefix[i - 1] + pow26[i];
    }

    public string solution(long n, string[] bans)
    {
        // 1. bans 의 전체 index 계산
        List<long> banIdx = new List<long>(bans.Length);

        foreach (var s in bans)
        {
            long idx = GetIndex(s);
            banIdx.Add(idx);
        }

        banIdx.Sort();

        // 2. 길이 L 결정 (보정 전 n 기준)
        int L = 1;
        while (L <= 11 && prefix[L] < n) L++;

        // 이때 L은 처음으로 prefix[L] >= n 인 길이

        // 3. 길이 1..L-1 에서 영향 주는 삭제 개수 반영
        long removedBefore = banIdx.Count(x => x <= prefix[L - 1]);
        n += removedBefore;

        // 4. 다시 길이 재계산
        while (L <= 11 && prefix[L] < n) L++;

        // L 길이 블록에서의 offset
        long offset = n - prefix[L - 1] - 1;  // 0-based

        // 5. 길이 L 블록 내에서 삭제 영향 반영
        // L 길이 문자열들의 실제 index 범위: prefix[L-1]+1 ~ prefix[L]
        long start = prefix[L - 1] + 1;
        long end = prefix[L];

        // L 길이 범위에 해당하는 ban indices만 찾아 offset 보정
        // 단, offset이 미치는 앞쪽만 고려
        int pos = banIdx.BinarySearch(start);
        if (pos < 0) pos = ~pos;

        while (pos < banIdx.Count && banIdx[pos] <= start + offset)
        {
            offset++;
            pos++;
        }

        // 6. offset → 문자열 생성
        return BuildString(L, offset);
    }

    // 문자열 s 의 전체 index
    private long GetIndex(string s)
    {
        int L = s.Length;
        long rank = 0;
        for (int i = 0; i < L; i++)
        {
            rank = rank * 26 + (s[i] - 'a');
        }
        return prefix[L - 1] + rank + 1;
    }

    // offset(0-based)을 길이 L 문자열로 변환
    private string BuildString(int L, long offset)
    {
        char[] arr = new char[L];
        for (int i = L - 1; i >= 0; i--)
        {
            arr[i] = (char)('a' + (offset % 26));
            offset /= 26;
        }
        return new string(arr);
    }
}