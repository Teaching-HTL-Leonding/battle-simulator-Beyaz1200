int health1 = 0;
int health2= 0;
int attack1 = 0;
int attack2 = 0;
int speed1 = 0;
int speed2= 0;
int Pirate = 0;
int Stonechewer = 0;
int GhostWarrior = 0;

Console.Write("Player 1 choose ur Charakter");
Console.WriteLine("Choose Pirate (1) Stonechewer (2) Outworlder (3)");
int Player1 = int.Parse(Console.ReadLine()!);


if (Player1 == Pirate) {health1  += 20; attack1  += 3; speed1  += 3;}
if (Player1 == Stonechewer) { health1 +=50; attack1 += 8; speed1 += 1;}
if (Player1 == GhostWarrior) { health1 +=20; attack1 += 2; speed1 +=5;}


Console.Write("Player 2 choose ur Charakter");
Console.WriteLine("Choose Pirate (1) Stonechewer (2) Outworlder (3)");
int Player2 = int.Parse(Console.ReadLine()!);


if (Player2 == Pirate) {health2  += 20; attack2  += 3; speed2  += 3;}
if (Player2 == Stonechewer) { health2 +=50; attack2 += 8; speed2 += 1;}
if (Player2 == GhostWarrior) { health2 +=20; attack2 += 2; speed2 +=5;}

while ( health1 > 0)
{
    health1= health1 - attack2 * speed2;
}
while (health2 > 0)
{
    health2 = health2 - attack1 * speed1;
}

if (health1 >= 0) {Console.WriteLine("Player1 has won");}
else if  ( health2 >= 0) {Console.WriteLine("Player2 has won");}








