using System.Transactions;

public class Entry
{
    public string _dateTime;
    public string _userEntry; 
    public string _prompt;

    public void Display()
    {
        Console.WriteLine($"{_dateTime}, {_prompt} \n {_userEntry}");
    }
}