global using System.Numerics;

Game();

static void Game()
{

    Player player = new Player();
    bool enemyLeft = false;

    bool questioning;

    //procent
    int playerAttackChance = 50;
    int playerCriticalAttackChance = 10;

    Enemy orc = new Enemy();
    enemyLeft = true;

    orc.Name = "Xull";

    while (player.hp > 0 && enemyLeft)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Bash-a-Monster.");

        Console.WriteLine("Please write a name for your hero:");
        
         player.Name = Console.ReadLine();

        questioning = true;
        while (questioning)
        {
            temp = Console.ReadLine();

            switch (temp)
            {
                case "hit":
                    orc.hp = Methods.PlayerAttack(player.damage, orc.hp);
                    break;

                case "":
                    break;

                default:
                    break;
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