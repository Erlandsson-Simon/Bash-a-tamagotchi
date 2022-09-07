public class Methods
{
    static string DoesPlayerAttackHit(int hitChance, int criticalHit)
    {

        Random R = new Random();

        string ret;

        int num = R.Next(1, 100);

        if (num < hitChance)
        {
            if (num < criticalHit)
            {
                ret = "critHit";
            }
            else
            {
                ret = "hit";
            }
        }
        else
        {
            ret = "miss";
        }

        return ret;
    }

    public static int PlayerAttack(int playerDamage, int EnemyHp)
    {

        EnemyHp -= playerDamage;

        return EnemyHp;
    }

    static int EnemyAttack(int enemyDamage, int playerHp)
    {

        playerHp -= enemyDamage;

        return playerHp;
    }
}