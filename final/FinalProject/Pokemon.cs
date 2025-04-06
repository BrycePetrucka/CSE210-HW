
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Pokemon
{
    private List<string> _pokemonList = new List<string>{"Charizard", "Blastoise", "Venasaur"};
    protected string _name;
    protected string _type;
    protected int _hp; //Hit points
    protected int _def; //Defense stat that deals with the attack stat
    protected int _specialDefense; // Defense stat that deals with attacks using special attack
    protected int _speed; //This will determine who goes first
    protected int _attack; //Regular attack stat
    protected int _specialAttack; //Special attack stat
    protected string _pokemonDescription;

    public string GetTheAttackType()
    {
        return _type;
    }
    public int GetHP()
    {
        return _hp;
    }
    public int GetDef()
    {
        return _def;
    }
    public int GetSpecialDefense()
    {
        return _specialDefense;
    }
    public int GetSpeed()
    {
        return _speed;
    }
    public int GetAttack()
    {
        return _attack;
    }
    public int GetSpecialAttack()
    {
        return _specialAttack;
    }
    public virtual void PokemonDescription()
    {
        Console.WriteLine("This pokemon is kinda like this...");
    }

    public string DisplayPokemon()
    {
        Console.WriteLine("Please type the number that matches the pokemon you want.");
        Thread.Sleep(2000);
        int counter = 0;
        foreach (string current in _pokemonList)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {current}");
            Thread.Sleep(400);
        }
        Console.Write("Choose your pokemon: ");
        string choice = Console.ReadLine();

        string chosenPokemon = "";
        while (chosenPokemon == "")
        {
            if (choice == "1")
            {
                chosenPokemon = "Charizard";
            }
            else if (choice == "2")
            {
                chosenPokemon = "Blastoise";
            }
            else if (choice == "3")
            {
                chosenPokemon = "Venasaur";
            }
            else
            {
                Console.WriteLine("Please choose one of the options.");
                Console.Write("Choose your pokemon: ");
                choice = Console.ReadLine();
            }
        }
        Console.Clear();
        return chosenPokemon;
    }

        public string EnemyPokemon(string yourPokemon)
        {
            _pokemonList.Remove(yourPokemon);
            Random _random = new Random();
            int randomNumber = _random.Next(_pokemonList.Count);
            string enemyPokemon = _pokemonList[randomNumber];

            Console.WriteLine($"Your opponent chooses {enemyPokemon}!");
            return enemyPokemon;
        }
}