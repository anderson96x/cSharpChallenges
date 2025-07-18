
Random attack = new Random();
int monsterHealth = 10;
int heroHealth = 10;
int damage = 0;

while (monsterHealth > 0 && heroHealth >0) {
    System.Console.WriteLine();
    
    //Hero attacking
    if (heroHealth >0) {
        damage = attack.Next(1,10);
        monsterHealth = monsterHealth - damage;
        if (isAlive(monsterHealth)) {
            System.Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
        } else {
            System.Console.WriteLine($"Monster was damaged and lost {damage} health.");
            System.Console.WriteLine("Hero wins!");
        }
    }
    

    //Monster attacking
    if (monsterHealth >0) {
        damage = attack.Next(1,10);
        heroHealth = heroHealth - damage;
        if (isAlive(heroHealth)) {
            System.Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
        } else {
            System.Console.WriteLine($"Hero was damaged and lost {damage} health.");
            System.Console.WriteLine("Monster wins!");
        }
    }
    
}



bool isAlive (int health) {
    if (health <= 0) {
        return false;
    }
    else {
        return true;
    }
}





/* Microsoft solution

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


*/