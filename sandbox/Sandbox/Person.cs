
using System.Diagnostics.Contracts;

public class Person
{
    private string _name;
    private int _age;

    public Person()
    {
        _name = "Unknown";
        _age = 0;
    }

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public void Display()
    {
        Console.WriteLine($"{_name} - {_age}");
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public int GetAge()
    {
        return _age;
    }

    public void SetAge(int age)
    {
        _age = age;
    }

    /*
    This is how you would make sure the age given is above 0
    public void SetAge(int age)
    {
        if (age >= 0)
        {
            _age = age;
        }
        else
        {
            _age = 0
        }
    } */
}   