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

     public static string player1()
     {
         WriteCentered("Write The name of player 1:");

         string playername1 = Console.ReadLine();
         
        while(playername1 == "") {
            WriteCentered("Write The name of player 1:");
            playername1 = Console.ReadLine();
        }

        return playername1;
        }

    public static string player2()
    {
        WriteCentered("Write The name of player 2:");

        string playername2 = Console.ReadLine();
        
        while(playername2 == ""){
            WriteCentered("Write the name of player 2:");
            playername2 = Console.ReadLine();
            
        }

        return playername2;

    }

    public static void displayfight(){

tb.WriteCentered(" #######                       ");
tb.WriteCentered(" #       #  ####  #    # ##### ");
tb.WriteCentered(" #       # #    # #    #   #   ");
tb.WriteCentered(" #####   # #      ######   #   ");
tb.WriteCentered(" #       # #  ### #    #   #   ");
tb.WriteCentered(" #       # #    # #    #   #   ");
tb.WriteCentered(" #       #  ####  #    #   #   ");
}

    


 }
