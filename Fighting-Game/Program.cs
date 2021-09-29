using System;

Console.WriteLine(" ");

Console.ForegroundColor = ConsoleColor.Red;
tb.displayfight();
Console.WriteLine(" ");
tb.WriteCentered("PRESS ENTER TO START");
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.White;
tb.player1();
tb.player2();