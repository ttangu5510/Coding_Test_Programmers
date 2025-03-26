using System;

public class Example
{
    public static void Main()
    {
        String s;
        Console.Clear();
        s = Console.ReadLine();
        char[] temp = s.ToCharArray();
        for(int i = 0;i<s.Length;i++)
        {
            if (char.IsLower(s[i]))
            {
                temp[i] = char.ToUpper(s[i]);
            }
            else if (char.IsUpper(s[i]))
            {
                temp[i] = char.ToLower(s[i]);
            }
            Console.Write(temp[i]);
        }
    }
}