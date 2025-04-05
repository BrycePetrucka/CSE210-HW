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
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
        }
        else if (chosenPokemon == "Blastoise")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Blastoise();
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
        }
        else if (chosenPokemon == "Venasaur")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Venasaur();
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
        }

        if (enemyPokemon == "Charizard")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Charizard();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
        }
        else if (enemyPokemon == "Blastoise")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Blastoise();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
        }
        else if (enemyPokemon == "Venasaur")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Venasaur();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
        }

        while (battle)
        {
            // this else if statement determines who gets to attack first
            if (playerPokemon.GetSpeed() > opponentPokemon.GetSpeed())
            {
                // this code is the logic for your move to function

                string chosenMove = playerMoves.ChooseMove();
                Console.Clear();
                int accuracy = playerMoves.GetAccuracy(chosenMove);
                int power = playerMoves.GetMovePower(chosenMove);
                string physicalOrSpecial = playerMoves.GetPhysicalOrSpecial(chosenMove);
                if (physicalOrSpecial == "phy")
                {
                    attackStat = playerPokemon.GetAttack();
                    defenseStat = opponentPokemon.GetDef();
                }
                else
                {
                    attackStat = playerPokemon.GetSpecialAttack();
                    defenseStat = opponentPokemon.GetSpecialDefense();
                }

                Battle _myTurn = new Battle(power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{chosenPokemon} use {chosenMove}!");

                damage = _myTurn.DamageCalculation();

                opponentCurrentHp = opponentCurrentHp - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"You deal {damage} damage");
                }
                Console.WriteLine();

                if (opponentCurrentHp <= 0)
                {
                    Console.WriteLine($"{enemyPokemon}: 0/{opponentHP}");
                    Console.WriteLine("You win!");
                    battle = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{enemyPokemon}: {opponentCurrentHp}/{opponentHP}");
                }

                // the following code is for the enemy to pick a move and use it

                chosenMove = opponentMoves.ChooseEnemyMove();
                accuracy = opponentMoves.GetAccuracy(chosenMove);
                power = opponentMoves.GetMovePower(chosenMove);
                physicalOrSpecial = opponentMoves.GetPhysicalOrSpecial(chosenMove);
                if (physicalOrSpecial == "phy")
                {
                    attackStat = opponentPokemon.GetAttack();
                    defenseStat = playerPokemon.GetDef();
                }
                else
                {
                    attackStat = opponentPokemon.GetSpecialAttack();
                    defenseStat = playerPokemon.GetSpecialDefense();
                }

                Battle _enemyTurn = new Battle(power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{enemyPokemon} used {chosenMove}!");

                damage = _enemyTurn.DamageCalculation();

                playerCurrentHP = playerCurrentHP - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"Your opponent dealt {damage} damage");
                }
                
                Console.WriteLine();

                if (playerCurrentHP <= 0)
                {
                    Console.WriteLine($"{playerPokemon}: 0/{playerHP}");
                    Console.WriteLine("You lose, better luck next time.");
                    battle = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{playerPokemon}: {playerCurrentHP}/{playerHP}");
                }
            }
            else
            {
                string chosenMove = opponentMoves.ChooseEnemyMove();
                int accuracy = opponentMoves.GetAccuracy(chosenMove);
                int power = opponentMoves.GetMovePower(chosenMove);
                string physicalOrSpecial = opponentMoves.GetPhysicalOrSpecial(chosenMove);
                if (physicalOrSpecial == "phy")
                {
                    attackStat = opponentPokemon.GetAttack();
                    defenseStat = playerPokemon.GetDef();
                }
                else
                {
                    attackStat = opponentPokemon.GetSpecialAttack();
                    defenseStat = playerPokemon.GetSpecialDefense();
                }

                Battle _enemyTurn = new Battle(power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{enemyPokemon} used {chosenMove}!");

                damage = _enemyTurn.DamageCalculation();

                playerCurrentHP = playerCurrentHP - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"Your opponent dealt {damage} damage");
                }
                
                Console.WriteLine();

                if (playerCurrentHP <= 0)
                {
                    Console.WriteLine($"{playerPokemon}: 0/{playerHP}");
                    Console.WriteLine("You lose, better luck next time.");
                    battle = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{playerPokemon}: {playerCurrentHP}/{playerHP}");
                }

                // this code starts your turn

                chosenMove = playerMoves.ChooseMove();
                Console.Clear();
                accuracy = playerMoves.GetAccuracy(chosenMove);
                power = playerMoves.GetMovePower(chosenMove);
                physicalOrSpecial = playerMoves.GetPhysicalOrSpecial(chosenMove);
                if (physicalOrSpecial == "phy")
                {
                    attackStat = playerPokemon.GetAttack();
                    defenseStat = opponentPokemon.GetDef();
                }
                else
                {
                    attackStat = playerPokemon.GetSpecialAttack();
                    defenseStat = opponentPokemon.GetSpecialDefense();
                }

                Battle _myTurn = new Battle(power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{chosenPokemon} use {chosenMove}!");

                damage = _myTurn.DamageCalculation();

                opponentCurrentHp = opponentCurrentHp - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"You deal {damage} damage");
                }
                Console.WriteLine();
                
                if (opponentCurrentHp <= 0)
                {
                    Console.WriteLine($"{enemyPokemon}: 0/{opponentHP}");
                    Console.WriteLine("You win!");
                    battle = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"{enemyPokemon}: {opponentCurrentHp}/{opponentHP}");
                }
            }
        }
    }
}