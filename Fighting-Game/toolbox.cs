using System;
public class tb
 {

public static void WriteCentered(string text){

    int a = Console.WindowWidth / 2;

    a -= text.Length / 2;

    for(int i = 0; i < a; i++)
    {
        Console.Write(" ");
    }
    Console.WriteLine(text);
}

        
        
}
