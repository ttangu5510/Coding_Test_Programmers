using System;

public class Test
{
	public static void Main()
	{
		var input = Console.ReadLine();
		if(string.IsNullOrEmpty(input)) return;
		
		int count = int.Parse(input);
		
		int up = 0;
		int bottom = count - 1;
		
		int[] card = new int[count];
		int cardCount = count;
		
		for(int i = 0; i < count; i++)
		{
			card[i] = i + 1;
		}
		
		while(cardCount > 1)
		{
			card[up] = 0; // 카드 버리기
			cardCount--;
			
			up++;
			if(up == count) up = 0;
			
			// 카드 1장 남으면 탈출
			if(cardCount == 1) break;
			
			// 카드 밑으로 옮기기
			bottom++;
			if(bottom == count) bottom = 0;
			
			card[bottom] = card[up];
			card[up] = 0;
			
			up++;
			if(up == count) up = 0;
		}
		
		Console.WriteLine(card[up]);
	}
}