using System;

Console.WriteLine(" ");

tb.displayfight();
Console.WriteLine(" ");
tb.WriteCentered("PRESS ENTER TO START");
Console.ReadLine();
Console.Clear();

Console.WriteLine(" ");
tb.displayfight();
Console.WriteLine(" ");
string p1name = tb.getplayer1name();
Console.Clear();
Console.WriteLine(" ");
tb.displayfight();
Console.WriteLine(" ");
string p2name = tb.getplayer2name();
Console.Clear();


int player1hp = 50;
int player2hp = 50;

tb.displayfight();
Console.WriteLine(" ");

Random rnd = new Random();



while (player1hp > 0 && player2hp > 0)
{

    int damage = rnd.Next(1, 20);

    player1hp = player1hp - damage;
    tb.WriteCentered($"{p1name} got hit by {p2name} and lost {damage} hp!");
    Console.ReadLine();

    damage = rnd.Next(1, 20);


    player2hp = player2hp - damage;
    tb.WriteCentered($"{p2name} got hit by {p1name} and lost {damage} hp!");
    Console.ReadLine();

}

if(player1hp < 1)
{
    Console.Clear();
    Console.WriteLine(" ");
    tb.displayfight();
    Console.WriteLine(" ");
    tb.WriteCentered($"{p2name} defeated the mighty {p1name} in a fight to the death!");
    Console.ReadLine();
    
    }

else if(player2hp < 1)
{
    Console.Clear();
    Console.WriteLine(" ");
    tb.displayfight();
    Console.WriteLine(" ");
    tb.WriteCentered($"{p1name} defeated the mighty {p2name} in a fight to the death!");
    Console.ReadLine();
    
}    
Console.Clear();
Console.WriteLine(" ");
tb.displayend();
Console.WriteLine(" ");
tb.WriteCentered("Thanks for playing!");
Console.ReadLine();















