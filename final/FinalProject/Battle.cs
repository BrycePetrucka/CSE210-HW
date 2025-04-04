public class Battle
{
    private int _attackingStat;
    private int _defendingStat;
    private int _movePower;
    private int _accuracy;

    public Battle(int power, int attack, int defense, int accuracy)
    {
        _attackingStat = attack;
        _defendingStat = defense;
        _accuracy = accuracy;
        _movePower = power;
    }

    public int DamageCalculation()
    {
        int damage = ((((2 * 50 / 5) + 2) * _movePower * (_attackingStat / _defendingStat)) / 50) + 2;
        return damage;
    }
}