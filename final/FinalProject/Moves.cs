using System.Runtime.InteropServices;
using System.Globalization;

public class Moves
{
    private int MOVE_NAME = 0;
    private int PHY_SPE = 1; // Checks if the move is a physical or special attack 
    // private int ATTCK_TYPE = 2;
    private int POWER = 3;
    private int ACCURACY = 4;
    List<string> _moves = new List<string>();
    List<string> _moveNames = new List<string>();

    
    public Moves(string pokemon)
    {
        if (pokemon == "Charizard")
        {
            // The moves are being added to a list based off what pokemon needs the list of moves
            // Split up with ";" so when printing it out it knows which part to print and which are the stats
            // "phy" stands for "physical" which means it will use the pokemons regualr attack stat
            // "spe" stands for "special" which means it will use a pokemons special attack stat 
            _moves.Add("Flame Thrower;spe;fire;90;95");
            _moves.Add("Fire Fang;spe;fire;65;90");
            _moves.Add("Air Slash;phy;flying;75;95");
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
            _moves.Add("Poison Jab;spe;poison;80;95");
        }
    }

    public string ChooseMove()
    {
        // this inital part will list all the moves and let you select one
        string theMove = "";
        Console.WriteLine("Select what move you would like to use by typing the name or the number associated with it.");
        while (theMove == "")
        {
            int counter = 1;
            foreach (string line in _moves)
            {
                string[] new_line = line.Split(';');
                Console.WriteLine($"{counter}. {new_line[MOVE_NAME]}");
                _moveNames.Add(new_line[MOVE_NAME]);
                counter += 1;
            }

            string chosenMove = Console.ReadLine();
            
            // this second part will use the same loop and assign what number you type
            // to the correct move that goes with it, so you only need to type in a number
            // rather than the move name itself
            if (chosenMove == "1" || chosenMove == "2" || chosenMove == "3" || chosenMove == "4")
            {
                int chosenMoveInt = int.Parse(chosenMove);
                counter = 1;
                foreach (string line in _moves)
                {
                    string[] new_line = line.Split(';');
                    if (chosenMoveInt == counter)
                    {
                        theMove = new_line[MOVE_NAME];
                    }
                    counter += 1;
                }
            }
            
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            chosenMove = textInfo.ToTitleCase(chosenMove.ToLower());
            if (_moveNames.Contains(chosenMove) && theMove == "")
            {
                theMove = chosenMove;
            }
            else if (!_moveNames.Contains(chosenMove) && theMove == "")
            {
                Console.Clear();
                Console.WriteLine("Please input either the number next to the move you wish to use, or the name of the move.");
            }
        }
        return theMove;
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
            // Console.WriteLine($"{new_line[MOVE_NAME]}");
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