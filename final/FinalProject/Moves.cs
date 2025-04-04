public class Moves
{
    private int MOVE_NAME = 0;
    private int PHY_SPE = 1; // Checks if the move is a physical or special attack 
    // private int ATTCK_TYPE = 2;
    private int POWER = 3;
    private int ACCURACY = 4;
    List<string> _moves = new List<string>();

    
    public Moves(string pokemon)
    {
        if (pokemon == "Charizard")
        {
            // The moves are being added to a list based off what pokemon needs the list of moves
            // Split up with ";" so when printing it out it knows which part to print and which are the stats
            // "phy" stands for "physical" which means it will use the pokemons regualr attack stat
            // "spe" stands for "special" which means it will use a pokemons special attack stat 
            _moves.Add("Flame Thrower;phy;fire;90;95");
            _moves.Add("Fire Fang;spe;fire;65;90");
            _moves.Add("Air Slash;spe;flying;75;95");
            _moves.Add("Dragon Rush;phy;dragon;100;75");
        }
        else if (pokemon == "Blastoise")
        {
            _moves.Add("Hydro Pump;spe;water;110;80");
            _moves.Add("Aqua Tail;phy;water;90;90");
            _moves.Add("Ice Beam;spe;ice;90;95");
            _moves.Add("Earthquake;spe;ground;100;95");
        }
        else if (pokemon == "Venasaur")
        {
            _moves.Add("Solar Beam;spe;grass;120;80");
            _moves.Add("Petal Blizzard;phy;grass;90;95");
            _moves.Add("Sludge Bomb;spe;poison;90;95");
            _moves.Add("Posion Jab;spe;poison;80;95");
        }
    }

    public string ChooseMove()
    {
        int counter = 1;
        foreach (string line in _moves)
        {
            string[] new_line = line.Split(';');
            Console.WriteLine($"{counter}. {new_line[MOVE_NAME]}");
            counter += 1;
        }

        string chosenMove = Console.ReadLine();
        return chosenMove;
    }

    public string ChooseEnemyMove()
    {
        Random random = new Random();
        int randomNumber = random.Next(1,5);
        string chosenMove = "";

        int counter = 1;
        foreach (string line in _moves)
        {
            string[] new_line = line.Split(';');
            if (randomNumber == counter)
            {
                chosenMove = new_line[MOVE_NAME];
            }
            counter += 1;
        }
        return chosenMove;
    }

    public string GetPhysicalOrSpecial(string moveName)
    {
        string phyOrSpe = "";
        foreach (string line in _moves)
        {
            string[] new_line = line.Split(';');
            if (new_line[MOVE_NAME] == moveName)
            {
                phyOrSpe = new_line[PHY_SPE];
            }
        }
        return phyOrSpe;
    }

    public int GetAccuracy(string moveName)
    {
        int moveAccuracy = 0;
        foreach (string line in _moves)
        {
            string[] new_line = line.Split(';');
            if (new_line[MOVE_NAME] == moveName)
            {
                moveAccuracy = int.Parse(new_line[ACCURACY]);
            }
        }
        return moveAccuracy;
    }

    public int GetMovePower(string moveName)
    {
        int power = 0;
        foreach (string line in _moves)
        {
            string[] new_line = line.Split(';');
            if (new_line[MOVE_NAME] == moveName)
            {
                power = int.Parse(new_line[POWER]);
            }
        }
        return power;
    }
}