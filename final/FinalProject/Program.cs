using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        bool battle = true;

        Pokemon _pokemon = new Pokemon();

        Console.WriteLine("Welcome to the pokemon battle simulator! Please choose your pokemon!");
        string ChooseYourPokemon()
        {
            string chosenPokemon = _pokemon.DisplayPokemon();
            Console.WriteLine($"You chose {chosenPokemon}!");
            return chosenPokemon;
        }

        string chosenPokemon = ChooseYourPokemon();
        string enemyPokemon = _pokemon.EnemyPokemon(chosenPokemon);

        Pokemon playerPokemon = null;
        Moves playerMoves = null;
        Pokemon opponentPokemon = null;
        Moves opponentMoves = null;
        int damage;
        int playerHP = 1;
        int playerCurrentHP = 1;
        int opponentHP = 1;
        int opponentCurrentHp = 1;
        int attackStat;
        int defenseStat;


        if (chosenPokemon == "Charizard")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Charizard();
            playerHP = playerPokemon._hp;
            playerCurrentHP = playerHP;
        }
        else if (chosenPokemon == "Blastoise")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Blastoise();
            playerHP = playerPokemon._hp;
            playerCurrentHP = playerHP;
        }
        else if (chosenPokemon == "Venasaur")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Venasaur();
            playerHP = playerPokemon._hp;
            playerCurrentHP = playerHP;
        }

        if (enemyPokemon == "Charizard")
        {
            opponentMoves = new Moves(chosenPokemon);
            opponentPokemon = new Charizard();
            opponentHP = opponentPokemon._hp;
            opponentCurrentHp = opponentHP;
        }
        else if (enemyPokemon == "Blastoise")
        {
            opponentMoves = new Moves(chosenPokemon);
            opponentPokemon = new Blastoise();
            opponentHP = opponentPokemon._hp;
            opponentCurrentHp = opponentHP;
        }
        else if (enemyPokemon == "Venasaur")
        {
            opponentMoves = new Moves(chosenPokemon);
            opponentPokemon = new Venasaur();
            opponentHP = opponentPokemon._hp;
            opponentCurrentHp = opponentHP;
        }

        while (battle)
        {
            if (playerPokemon._speed > opponentPokemon._speed)
            {
                string chosenMove = playerMoves.ChooseMove();
                int accuracy = playerMoves.GetAccuracy(chosenMove);
                int power = playerMoves.GetMovePower(chosenMove);
                string physicalOrSpecial = playerMoves.GetPhysicalOrSpecial(chosenMove);
                if (physicalOrSpecial == "phy")
                {
                    attackStat = playerPokemon._attack;
                    defenseStat = opponentPokemon._def;
                }
                else
                {
                    attackStat = playerPokemon._specialAttack;
                    defenseStat = opponentPokemon._specialDefense;
                }

                Battle _myTurn = new Battle(chosenPokemon, opponentHP, power, attackStat, defenseStat, accuracy);
                damage = _myTurn.DamageCalculation();

                opponentCurrentHp = opponentCurrentHp - damage;

                Console.WriteLine($"{chosenPokemon} use {chosenMove}!");
                Console.WriteLine($"You deal {damage} damage");
                Console.WriteLine($"{enemyPokemon}: {opponentCurrentHp}/{opponentHP}");
            }
            else
            {
                Console.WriteLine("You are slower");
            }
        }
    }
}