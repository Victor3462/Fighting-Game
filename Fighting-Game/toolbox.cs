using System;
public class tb
{

    public static void WriteCentered(string text)
    {

        int a = Console.WindowWidth / 2;

        a -= text.Length / 2;

        for (int i = 0; i < a; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(text);
    }
    // Gör så att det jag skriver i consolen blir centrerat

    public static string getplayer1name()
    {
        WriteCentered("Write The name of player 1:");

        string playername1 = Console.ReadLine();

        while (playername1 == "")
        {
            WriteCentered("Write The name of player 1:");
            playername1 = Console.ReadLine();
        }

        return playername1;
    }
    // Gör en string för playername2 och frågar spelaren att skriva namn för den och vägrar fortsätta utan namnet.

    public static string getplayer2name()
    {
        WriteCentered("Write The name of player 2:");

        string playername2 = Console.ReadLine();

        while (playername2 == "")
        {
            WriteCentered("Write the name of player 2:");
            playername2 = Console.ReadLine();

        }

        return playername2;

    }
    // Gör en string för playername 2 och frågar spelaren att skriva namn för den och vägrar fortsätta utan namnet

    public static void displayfight()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        tb.WriteCentered(" #######                       ");
        tb.WriteCentered(" #       #  ####  #    # ##### ");
        tb.WriteCentered(" #       # #    # #    #   #   ");
        tb.WriteCentered(" #####   # #      ######   #   ");
        tb.WriteCentered(" #       # #  ### #    #   #   ");
        tb.WriteCentered(" #       # #    # #    #   #   ");
        tb.WriteCentered(" #       #  ####  #    #   #   ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    // Gör så att jag slipper göra ascci art varje gång jag behöver den

    public static void displayend()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        tb.WriteCentered("  ::::::::::: :::    ::: ::::::::::          :::::::::: ::::    ::: ::::::::: ");
        tb.WriteCentered("     :+:     :+:    :+: :+:                 :+:        :+:+:   :+: :+:    :+: ");
        tb.WriteCentered("    +:+     +:+    +:+ +:+                 +:+        :+:+:+  +:+ +:+    +:+  ");
        tb.WriteCentered("   +#+     +#++:++#++ +#++:++#            +#++:++#   +#+ +:+ +#+ +#+    +:+   ");
        tb.WriteCentered("  +#+     +#+    +#+ +#+                 +#+        +#+  +#+#+# +#+    +#+    ");
        tb.WriteCentered(" #+#     #+#    #+# #+#                 #+#        #+#   #+#+# #+#    #+#     ");
        tb.WriteCentered("###     ###    ### ##########          ########## ###    #### #########       ");

        {

        }
    }


    public static void fighters()
    {

        WriteCentered("(*-*)-|  |-(^-^)");
        
        }



}
