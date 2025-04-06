using System.Reflection.Metadata;

public class Battle
{
    private string _attackerType;
    private string _defenderType;
    private string _moveType;
    private int _attackingStat;
    private int _defendingStat;
    private int _movePower;
    private int _accuracy;

    public Battle(string attacker, string defender, string moveType, int power, int attack, int defense, int accuracy)
    {
        _attackerType = attacker;
        _defenderType = defender;
        _moveType = moveType;
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
        // STAB stands for "Same type attack bonus" aka if you are a fire type
        // and you use a fire type move, you will do bonus damage
        double stabMultiplier = 1;
        // type advantage is if one type is effective agaisnt the other it does
        // extra damage
        int typeAdvantage = 1;

        if (_moveType == "fire" && _defenderType == "Grass")
        {
            typeAdvantage = 2;
        }
        else if (_moveType == "grass" && _defenderType == "Water")
        {
            typeAdvantage = 2;
        }
        else if (_moveType == "water" && _defenderType == "Fire")
        {
            typeAdvantage = 2;
        }

        if (_attackerType == "Fire" && _moveType == "fire")
        {
            stabMultiplier = 1.5;
        }
        else if (_attackerType == "Water" && _moveType == "water")
        {
            stabMultiplier = 1.5;
        }
        else if (_attackerType == "Grass" && _moveType == "grass")
        {
            stabMultiplier = 1.5;
        }

        int accuracyChance = random.Next(1,101);

        int critChance = random.Next(1,11);

        if (accuracyChance <= _accuracy && critChance == 10)
        { 
            damage = (int)((((((2 * 50 * 2 / 5) + 2) * _movePower * ((float)_attackingStat / (float)_defendingStat)) / 50) + 2) * (double)stabMultiplier * (int)typeAdvantage); 
            Console.WriteLine("A critical hit!");
            Thread.Sleep(1000);
        }
        else if (accuracyChance <= _accuracy)
        {
            // I got this damage equasion online and translated it into code format
            // I apologize for the "()" monster that it is
            damage = (int)((((((2 * 50 / 5) + 2) * _movePower * ((float)_attackingStat / (float)_defendingStat)) / 50) + 2) * (double)stabMultiplier * (int)typeAdvantage);
            if (typeAdvantage == 2)
            {
                Console.WriteLine("Its super effective!");
                Thread.Sleep(500);
            }
        }
        else
        {
            Console.WriteLine("The attack missed!");
            Thread.Sleep(1000);
        }
        return damage;
    }

    public void DamageAnimation(int damage, int totalHP, int currentHP, string pokemon)
    {
        int timer;
        if (damage > 200)
        {
            timer = 5;
        }
        else if (damage > 100)
        {
            timer = 15;
        }
        else
        {
            timer = 30;
        }
        Thread.Sleep(800);
        Console.Write($"{pokemon}: {currentHP}/{totalHP}");
        Thread.Sleep(500);
        Console.Clear();

        Console.Write($"{pokemon}:");

        for (int i = 0 ; i < damage ; i++)
        {
            if (currentHP >= 101)
            {
                currentHP = currentHP - 1;
                Console.Write($" {currentHP}/{totalHP} ");
                Thread.Sleep(timer);
                Console.Write("\b\b\b\b\b\b\b\b\b");
            }
            else if (currentHP <= 100 && currentHP > 10)
            {
                currentHP = currentHP - 1;
                Console.Write($" {currentHP}/{totalHP} ");
                Thread.Sleep(timer);
                Console.Write("\b\b\b\b\b\b\b\b");
            }
            else if (currentHP <= 10 && currentHP > 0)
            {
                currentHP = currentHP - 1;
                Console.Write($" {currentHP}/{totalHP} ");
                Thread.Sleep(timer);
                Console.Write("\b\b\b\b\b\b\b");
            }
            else
            {
                break;
            }

        }
        Thread.Sleep(800);
        Console.Clear();
    }
}