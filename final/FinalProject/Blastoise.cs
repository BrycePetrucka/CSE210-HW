public class Blastoise : Pokemon
{
    public Blastoise() : base()
    {
        _name = "Blastoise";
        _type = "Water";
        _hp = 364;
        _def = 100;
        _specialDefense = 105;
        _speed = 78;
        _attack = 83;
        _specialAttack = 85;
    }

    public override void PokemonDescription()
    {
        Console.WriteLine("Blastoise is a water type. Strong agaisnt fire but weak against grass.");
        Thread.Sleep(4500);
        Console.WriteLine("Blastoise excels in defense, but doesnt have great attack stats or speed.");
    }
}