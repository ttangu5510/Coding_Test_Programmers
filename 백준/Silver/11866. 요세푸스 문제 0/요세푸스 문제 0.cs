using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
		StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
		
		var input = sr.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int[] nums = Array.ConvertAll(input.Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
		
		int[] answer = Josephus(nums[0], nums[1]);
		StringBuilder sb = new StringBuilder();
		sb.Append("<");
		for(int i = 0; i < answer.Length - 1; i++)
		{
			sb.Append($"{answer[i] + 1}, ");
		}
		sb.Append($"{answer[^1] + 1}>");
		sw.Write(sb);
		sw.Flush();
		sw.Close();
		sr.Close();
	}
	
	public static int[] Josephus(int n, int k)
	{
		int[] data = new int[n];
		// 생존한 사람은 1, 죽은 사람은 0
		for(int i = 0; i < n; i++) data[i] = 1;
		// 세그먼트 트리 초기화
		SegmentTree st = new SegmentTree(data);
		int[] result = new int[n];
		int currentPos = 1; // 현재 순서
		
		for(int i = 0; i < n; i++)
		{
			// 현재 생존자
			int survivors = st.Tree[1];
			// 현재 순서의 번호를 찾음
			currentPos = (currentPos + k - 2) % survivors + 1;
			result[i] = st.FindAndKill(currentPos);
		}
		
		return result;
	}
}

// 구간합 세그먼트 트리
public class SegmentTree
{
	private int[] tree;
	public int[] Tree => tree;
	private int size;
	
	public SegmentTree(int[] array)
	{
		size = array.Length;
		tree = new int[size * 4];
		Init(array, 1, 0, size - 1);
	}
	
	
	private void Init(int[] array, int node, int start, int end)
	{
		if(start == end) // 리프노드일 경우
		{
			tree[node] = array[start];
			return;
		}
		
		int mid = start + (end - start) / 2;
		
		Init(array, node * 2, start, mid);
		Init(array, node * 2 + 1, mid + 1, end);
		
		tree[node] = tree[node * 2] + tree[node * 2 + 1];
	}
	
	// 갱신: 0-based (인덱스 기준 갱신)
	public void Update(int targetIndex, int addValue)
	{
		Update(1, 0, size - 1, targetIndex, addValue);
	}
	
	private void Update(int node, int start, int end, int targetIndex, int addValue)
	{
		if(targetIndex == start && start == end) // 리프 노드 도달 시
		{
			tree[node] += addValue;
			return;
		}
		
		int mid = start + (end - start) / 2;
		int leftChild = node * 2;
		int rightChild = node * 2 + 1;
		
		if(targetIndex <= mid) // 목표가 왼쪽에 있을 경우
			Update(leftChild, start, mid, targetIndex, addValue);
		else // 오른쪽에 있을 경우
			Update(rightChild, mid + 1, end, targetIndex, addValue);
		
		tree[node] = tree[leftChild] + tree[rightChild];
	}
	// 쿼리 생략
	
	// 요세푸스
	public int FindAndKill(int killRank)
	{
		return FindAndKill(1, 0, size - 1, killRank);
	}
	
	private int FindAndKill(int node, int start, int end, int killRank)
	{
		if(start == end)
		{
			tree[node] = 0;
			return start;
		}
		
		int mid = start + (end - start) / 2;
		int leftChild = node * 2;
		int rightChild = node * 2 + 1;
		int killedIndex;
		// 만약 찾는 구간합(살아남은 인원의 수)이 왼쪽에 있을 경우
		if(killRank <= tree[leftChild])
			killedIndex = FindAndKill(leftChild, start, mid, killRank);
		// 오른쪽에 있을 경우. 지금까지의 합산을 killRank에서 빼야 함
		else
			killedIndex = FindAndKill(rightChild, mid + 1, end, killRank - tree[leftChild]);
		
		// 죽였으니(0으로 바꿨으니) 구간합 업데이트
		tree[node] = tree[leftChild] + tree[rightChild];
		
		return killedIndex;
	}
}