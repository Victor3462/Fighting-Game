using System;

Console.WriteLine(" ");

tb.displayfight();
Console.WriteLine(" ");
tb.WriteCentered("PRESS ENTER TO START");
Console.ReadLine();
Console.Clear();

tb.displayfight();
Console.WriteLine(" ");
tb.getplayer1name();
Console.Clear();
tb.displayfight();
Console.WriteLine(" ");
tb.getplayer2name();
Console.Clear();


int player1hp = 100;
int player2hp = 100;

tb.displayfight();
Console.WriteLine(" ");

Random rnd = new Random();

int damage1 = rnd.Next(20);







