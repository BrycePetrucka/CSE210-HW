public class Charizard : Pokemon
{
    public Charizard() : base()
    {
        _name = "Charizard";
        _type = "Fire";
        _hp = 360;
        _def = 78;
        _specialDefense = 85;
        _speed = 100;
        _attack = 84;
        _specialAttack = 109;
    }

    public override void PokemonDescription()
    {
        Console.WriteLine("Charizard is a fire type. They are strong against grass types but weak to water types");
        Thread.Sleep(4500);
        Console.WriteLine("Charizard excels at dealing damage and moving fast, but doesnt have much defense.");
    }
}