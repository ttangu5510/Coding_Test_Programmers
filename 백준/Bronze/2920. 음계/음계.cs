using System;

public class Program{
    public static void Main(){
        var input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)) return;
        
        if(input == "1 2 3 4 5 6 7 8")
            Console.WriteLine("ascending");
        else if(input =="8 7 6 5 4 3 2 1")
            Console.WriteLine("descending");
        else
            Console.WriteLine("mixed");
    }
}