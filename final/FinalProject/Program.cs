using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        bool battle = true;
        Pokemon playerPokemon = null;
        Moves playerMoves = null;
        Pokemon opponentPokemon = null;
        Moves opponentMoves = null;
        int damage;
        int playerHP = 1;
        int playerCurrentHP = 1;
        int opponentHP = 1;
        int opponentCurrentHp = 1;
        int animationHP = 1;
        int attackStat;
        int defenseStat;

        Pokemon _pokemon = new Pokemon();
        Console.Clear(); // this clear is to make sure nothing else is in the console when the program starts
        Console.WriteLine("Welcome to the pokemon battle simulator! Please choose your pokemon!");
        Thread.Sleep(2000);

        string ChooseYourPokemon()
        {
            string chosenPokemon = _pokemon.DisplayPokemon();
            Console.WriteLine($"You chose {chosenPokemon}!");
            Thread.Sleep(1000);
            return chosenPokemon;
        }

        string chosenPokemon = ChooseYourPokemon();

        if (chosenPokemon == "Charizard")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Charizard();
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
            playerPokemon.PokemonDescription();
        }
        else if (chosenPokemon == "Blastoise")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Blastoise();
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
            playerPokemon.PokemonDescription();
        }
        else if (chosenPokemon == "Venasaur")
        {
            playerMoves = new Moves(chosenPokemon);
            playerPokemon = new Venasaur();
            playerHP = playerPokemon.GetHP();
            playerCurrentHP = playerHP;
            playerPokemon.PokemonDescription();
        }

        Thread.Sleep(6000);
        string enemyPokemon = _pokemon.EnemyPokemon(chosenPokemon);

        if (enemyPokemon == "Charizard")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Charizard();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
            Thread.Sleep(1000);
            opponentPokemon.PokemonDescription();
        }
        else if (enemyPokemon == "Blastoise")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Blastoise();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
            Thread.Sleep(1000);
            opponentPokemon.PokemonDescription();
        }
        else if (enemyPokemon == "Venasaur")
        {
            opponentMoves = new Moves(enemyPokemon);
            opponentPokemon = new Venasaur();
            opponentHP = opponentPokemon.GetHP();
            opponentCurrentHp = opponentHP;
            Thread.Sleep(1000);
            opponentPokemon.PokemonDescription();
        }
        Thread.Sleep(6000);

        while (battle)
        {
            Console.Clear();
            Console.WriteLine($"{enemyPokemon}: {opponentCurrentHp}/{opponentHP}");
            Console.WriteLine();
            Console.WriteLine($"{playerPokemon}: {playerCurrentHP}/{playerHP}");
            Console.WriteLine();
            // this else if statement determines who gets to attack first
            if (playerPokemon.GetSpeed() > opponentPokemon.GetSpeed())
            {
                // this code is the logic for your move to function

                string playerType = playerPokemon.GetTheAttackType();
                string enemyType = opponentPokemon.GetTheAttackType();
                string chosenMove = playerMoves.ChooseMove();
                string chosenMoveType = playerMoves.GetMoveType(chosenMove);
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

                Battle _myTurn = new Battle(playerType, enemyType, chosenMoveType, power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{chosenPokemon} use {chosenMove}!");
                Thread.Sleep(2000);

                damage = _myTurn.DamageCalculation();

                animationHP = opponentCurrentHp;
                opponentCurrentHp = opponentCurrentHp - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"You deal {damage} damage");
                    _myTurn.DamageAnimation(damage, opponentHP, animationHP, enemyPokemon);
                }
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
                    Thread.Sleep(400);
                }

                // the following code is for the enemy to pick a move and use it

                enemyType = opponentPokemon.GetTheAttackType();
                playerType = playerPokemon.GetTheAttackType();
                chosenMove = opponentMoves.ChooseEnemyMove();
                accuracy = opponentMoves.GetAccuracy(chosenMove);
                chosenMoveType = opponentMoves.GetMoveType(chosenMove);
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

                Battle _enemyTurn = new Battle(enemyType, playerType, chosenMoveType, power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{enemyPokemon} used {chosenMove}!");
                Thread.Sleep(2000);

                damage = _enemyTurn.DamageCalculation();

                animationHP = playerCurrentHP;
                playerCurrentHP = playerCurrentHP - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"Your opponent dealt {damage} damage");
                    _enemyTurn.DamageAnimation(damage, playerHP, animationHP, chosenPokemon);
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
                    Thread.Sleep(400);
                }
            }
            else
            {
                string enemyType = opponentPokemon.GetTheAttackType();
                string playerType = playerPokemon.GetTheAttackType();
                string chosenMove = opponentMoves.ChooseEnemyMove();
                int accuracy = opponentMoves.GetAccuracy(chosenMove);
                string chosenMoveType = playerMoves.GetMoveType(chosenMove);
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

                Battle _enemyTurn = new Battle(enemyType, playerType, chosenMoveType, power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{enemyPokemon} used {chosenMove}!");
                Thread.Sleep(2000);

                damage = _enemyTurn.DamageCalculation();

                playerCurrentHP = playerCurrentHP - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"Your opponent dealt {damage} damage");
                    _enemyTurn.DamageAnimation(damage, playerHP, animationHP, chosenPokemon);
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
                    Thread.Sleep(400);
                }

                // this code starts your turn

                enemyType = opponentPokemon.GetTheAttackType();
                playerType = playerPokemon.GetTheAttackType();
                chosenMove = playerMoves.ChooseMove();
                Console.Clear();
                accuracy = playerMoves.GetAccuracy(chosenMove);
                chosenMoveType = playerMoves.GetMoveType(chosenMove);
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

                Battle _myTurn = new Battle(playerType, enemyType, chosenMoveType, power, attackStat, defenseStat, accuracy);

                Console.WriteLine($"{chosenPokemon} use {chosenMove}!");
                Thread.Sleep(2000);

                damage = _myTurn.DamageCalculation();

                opponentCurrentHp = opponentCurrentHp - damage;

                damage = _myTurn.DamageCalculation();

                animationHP = opponentCurrentHp;
                opponentCurrentHp = opponentCurrentHp - damage;

                if (damage != 0)
                {
                    Console.WriteLine($"You deal {damage} damage");
                    _myTurn.DamageAnimation(damage, opponentHP, animationHP, enemyPokemon);
                }
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
                    Thread.Sleep(400);
                }
            }
        }
    }
}