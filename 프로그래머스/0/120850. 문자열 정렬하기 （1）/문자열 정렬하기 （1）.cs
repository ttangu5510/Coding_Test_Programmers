using System;

public class Solution {
    public int[] solution(string my_string) {
        string temp="";
for(int i = 0; i < my_string.Length;i++)
{
    if (Char.IsDigit(my_string[i]))
    {
        temp += my_string[i];
    }
}
char[] temp2 = temp.ToCharArray();
Array.Sort(temp2);
int[] answer = new int[temp2.Length];
int count = 0;
foreach(char a in temp2)
{
    answer[count] = a - '0';
    count++;
}

        
        return answer;
    }
}