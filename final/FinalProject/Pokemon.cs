
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Pokemon
{
    public List<string> _pokemonList = new List<string>{"Charizard", "Blastoise", "Venasaur"};
    public string _name;
    public int _hp; //Hit points
    public int _def; //Defense stat that deals with the attack stat
    public int _specialDefense; // Defense stat that deals with attacks using special attack
    public int _speed; //This will determine who goes first
    public int _attack; //Regular attack stat
    public int _specialAttack; //Special attack stat

    public string DisplayPokemon()
    {
        Console.WriteLine("Please type the number that matches the pokemon you want.");
        int counter = 0;
        foreach (string current in _pokemonList)
        {
            counter += 1;
            Console.WriteLine($"{counter}. {current}");
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
        return chosenPokemon;
    }

        public string EnemyPokemon(string yourPokemon)
        {
            _pokemonList.Remove($"{yourPokemon}");
            Random _random = new Random();
            int randomNumber = _random.Next(_pokemonList.Count);
            string enemyPokemon = _pokemonList[randomNumber];

            Console.WriteLine($"Your opponent chooses {enemyPokemon}!");
            return enemyPokemon;
        }
}