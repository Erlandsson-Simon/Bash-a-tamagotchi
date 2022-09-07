global using System.Numerics;

Game();

static void Game()
{

    Player player = new Player();
    bool enemyLeft = false;

    //procent
    int playerAttackChance = 50;
    int playerCriticalAttackChance = 10;

    Enemy orc = new Enemy();
    enemyLeft = true;

    player.Name = "Knut";
    orc.Name = "Xull";

    while (player.hp > 0 && enemyLeft)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Bash-a-Monster.");

        Console.WriteLine("Please write a name for your hero:");
        string temp;

        while (condition)
        {
            temp = Console.ReadLine();

        switch (temp)
        {
            
            default:
            break;
        }

        if (temp == "hit")
        {
            orc.hp = Methods.PlayerAttack(player.damage, orc.hp);
        }
        }
        
    }

    if (player.hp > 0)
    {
        Console.WriteLine("You have Won!");
    }
    else
    {
        Console.WriteLine("You have died!");
    }

    Console.ReadLine();
}