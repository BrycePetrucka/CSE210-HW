public class Battle
{
    private int _attackingStat;
    private int _defendingStat;
    private int _movePower;
    private int _accuracy;

    public Battle(int power, int attack, int defense, int accuracy)
    {
        _attackingStat = attack;
        _defendingStat = defense;
        _accuracy = accuracy;
        _movePower = power;
    }

    public int DamageCalculation()
    {
        int damage = 0;
        // this random is used to check if the move misses based of its accuracy
        Random random = new Random();
        int accuracyChance = random.Next(1,101);

        int critChance = random.Next(1,11);

        if (accuracyChance <= _accuracy && critChance == 10)
        { 
            damage = (int)((((2 * 50 * 2 / 5) + 2) * _movePower * ((float)_attackingStat / (float)_defendingStat)) / 50) + 2; 
            Console.WriteLine("A critical hit!");
        }
        else if (accuracyChance <= _accuracy)
        {
            damage = (int)(((((2 * 50 / 5) + 2) * _movePower * ((float)_attackingStat / (float)_defendingStat)) / 50) + 2);

        }
        else
        {
            Console.WriteLine("The attack missed!");
        }
        return damage;
    }
}