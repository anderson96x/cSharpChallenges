/*
If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
If all three dice you roll result in the same value, you get six bonus points for rolling triples.
If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/

Random rollDice1 = new Random();
Random rollDice2 = new Random();
Random rollDice3 = new Random();

int dice1 = rollDice1.Next(1,7);
int dice2 = rollDice2.Next(1,7);
int dice3 = rollDice3.Next(1,7);
int score = 0;


Console.WriteLine("Rolling dices...");
Console.WriteLine();
Console.WriteLine($"Dice 1: {dice1}");
Console.WriteLine($"Dice 2: {dice2}");
Console.WriteLine($"Dice 3: {dice3}");

score = dice1 + dice2 + dice3;
if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3) {
    if (dice1 == dice2 && dice2 == dice3) {
        score +=6;
    } else {
        score +=2;
    }
}

Console.WriteLine();
Console.WriteLine($"Score: {score}");
Console.WriteLine();

if (score >= 15) {
    Console.WriteLine("#### You win ####");
} else {
    Console.WriteLine("#### You lose ####");
}




 