public class Venasaur : Pokemon
{
    public Venasaur() : base()
    {
        _name = "Venasaur";
        _type = "Grass";
        _hp = 368;
        _def = 83;
        _specialDefense = 100;
        _speed = 80;
        _attack = 82;
        _specialAttack = 100;
    } 

    public override void PokemonDescription()
    {
        Console.WriteLine("Venasaur is a grass type. They are strong agaisnt water types but weak agaisnt fire types.");
        Thread.Sleep(4500);
        Console.WriteLine("Venasaur has solid special attack and special defense, but lacks in physical defense and attack.");
    }
}